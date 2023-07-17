using RetailApp.ViewModels.Fiscal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RetailApp.Utility
{
    public static class Calculadora
    {
        public static decimal calculaPreco(det produto, ICMSTot ICMStot, int regime)
        {
            //tratar os dados de ICMS
            Valida ICMS = new Valida();
            ICMS = ICMS.ValidaICMS(produto);


            //Pegar os valores usados no calculo
            //decimal valorProduto = produto.prod.vUnTrib * produto.prod.qTrib;
            decimal valorProduto = produto.prod.vProd;
            decimal valorIPI = produto.imposto.IPI.IPITrib.vIPI;
            decimal valorICMS = ICMS.valorICMS;
            decimal valorST = ICMS.valorICMSST;
            decimal FCPST = ICMS.valorFCPST;
            decimal difal = produto.imposto.ICMSUFDest.vICMSUFDest;
            decimal frete = calculaFrete(produto, ICMStot);
            decimal despesas = calculaDespesa(produto, ICMStot);
            decimal seguro = calculaSeguro(produto, ICMStot);
            decimal icmsDesonerado = ICMS.valorICMSDesonerado;
            decimal precoCusto = 0;
            decimal valorPis = produto.imposto.PIS.PISAliq.vPIS;
            decimal valorCofins = produto.imposto.COFINS.COFINSAliq.vCOFINS;

            //calculo para o simples nacional
            if (regime == 0)
            {
                precoCusto = (valorProduto + valorIPI + valorST + FCPST + frete + despesas + seguro + difal - icmsDesonerado) / produto.prod.qTrib;

                return Math.Round(precoCusto, 2);
            }
            //calculo para simples nacional sublimite e lucro presumido
            else if (regime == 1 || regime == 2)
            {
                if(valorST > 0)
                {
                    precoCusto = (valorProduto + valorIPI + FCPST + frete + despesas + seguro + difal - icmsDesonerado + valorST) / produto.prod.qTrib;
                }
                else
                {
                    precoCusto = (valorProduto - valorICMS + valorIPI + FCPST + frete + despesas + seguro + difal - icmsDesonerado) / produto.prod.qTrib;
                }
                return Math.Round(precoCusto, 2);
            }
            //calculo para o lucro real AJUSTAR CALCULO
            else if (regime == 3 )
            {
                if (valorST > 0)
                {
                    precoCusto = (valorProduto - valorPis - valorCofins + valorIPI + FCPST + frete + despesas + seguro + difal - icmsDesonerado + valorST) / produto.prod.qTrib;
                }
                else
                {
                    precoCusto = (valorProduto - valorICMS - valorPis - valorCofins + valorIPI + FCPST + frete + despesas + seguro + difal - icmsDesonerado) / produto.prod.qTrib;
                }
                return Math.Round(precoCusto, 2);
            }
            return Math.Round(precoCusto, 2);
        }


        //ratear as despesas entre os produtos
            public static decimal calculaFrete(det produto, ICMSTot ICMStot)
        {
            decimal frete = ICMStot.vFrete * (produto.prod.vProd / ICMStot.vProd);
            return Math.Round(frete, 2);
        }

        public static decimal calculaDespesa(det produto, ICMSTot ICMStot)
        {
            decimal despesa = ICMStot.vOutro * (produto.prod.vProd / ICMStot.vProd);
            return Math.Round(despesa, 2);
        }

        public static decimal calculaSeguro(det produto, ICMSTot ICMStot)
        {
            decimal seguro = ICMStot.vSeg * (produto.prod.vProd / ICMStot.vProd);
            return Math.Round(seguro, 2);
        }
    }
}
