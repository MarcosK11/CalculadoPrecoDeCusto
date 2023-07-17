using RetailApp.ViewModels.Fiscal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RetailApp.Utility
{

    public class Valida
    {
        public decimal valorICMS { get; set; } = default!;
        public decimal valorICMSST { get; set; } = default!;
        public decimal valorICMSDesonerado { get; set; } = default!;
        public decimal valorFCPST { get; set; } = default!;

        public Valida ValidaICMS(det produto)
        {
            Valida ICMS = new Valida()!;
            if (produto.imposto.ICMS.ICMSBase is ICMS00 icms00)
            {
                ICMS.valorICMS = icms00.vICMS;
                ICMS.valorICMSST = 0;
                ICMS.valorICMSDesonerado = 0;
                ICMS.valorFCPST = icms00.vFCPST;
            }
            else if (produto.imposto.ICMS.ICMSBase is ICMS10 icms10)
            {
                ICMS.valorICMS = icms10.vICMS;
                ICMS.valorICMSST = icms10.vICMSST;
                ICMS.valorICMSDesonerado = 0;
                ICMS.valorFCPST = icms10.vFCPST;
            }
            else if (produto.imposto.ICMS.ICMSBase is ICMS20 icms20)
            {
                ICMS.valorICMS = icms20.vICMS;
                ICMS.valorICMSST = 0;
                ICMS.valorICMSDesonerado = 0;
                ICMS.valorFCPST = icms20.vFCPST;
            }
            else if (produto.imposto.ICMS.ICMSBase is ICMS30 icms30)
            {
                ICMS.valorICMS = icms30.vICMS;
                ICMS.valorICMSST = icms30.vICMSST;
                ICMS.valorICMSDesonerado = icms30.vICMSDeson;
                ICMS.valorFCPST = icms30.vFCPST;
            }
            else if (produto.imposto.ICMS.ICMSBase is ICMS40 icms40)
            {
                ICMS.valorICMS = 0;
                ICMS.valorICMSST = 0;
                ICMS.valorICMSDesonerado = icms40.vICMSDeson;
                ICMS.valorFCPST = icms40.vFCPST;
            }
            else if (produto.imposto.ICMS.ICMSBase is  ICMS51 icms51)
            {
                ICMS.valorICMS = 0;
                ICMS.valorICMSST = 0;
                ICMS.valorICMSDesonerado = 0;
                ICMS.valorFCPST = icms51.vFCPST;
            }
            else if (produto.imposto.ICMS.ICMSBase is ICMS60 icms60)
            {
                ICMS.valorICMS = 0;
                ICMS.valorICMSST = 0;
                ICMS.valorICMSDesonerado = 0;
                ICMS.valorFCPST = icms60.vFCPST;
            }
            else if (produto.imposto.ICMS.ICMSBase is ICMS70 icms70)
            {
                ICMS.valorICMS = icms70.vICMS;
                ICMS.valorICMSST = icms70.vICMSST;
                ICMS.valorICMSDesonerado = icms70.vICMSDeson;
                ICMS.valorFCPST = icms70.vFCPST;
            }
            else if (produto.imposto.ICMS.ICMSBase is ICMS90 icms90)
            {
                ICMS.valorICMS = icms90.vICMS;
                ICMS.valorICMSST = icms90.vICMSST;
                ICMS.valorICMSDesonerado = icms90.vICMSDeson;
                ICMS.valorFCPST = icms90.vFCPST;
            }
            ICMS = validaST(ICMS);
            return ICMS;
        }

        private static Valida validaST(Valida ICMS)
        {
            if(ICMS.valorICMSST > 0)
            {
                ICMS.valorICMS = 0;
            }
            return ICMS;
        }

        public static det validaDados(det produto)
        {
            det produtoN = produto;

            if (produto.imposto.IPI == null || produto.imposto.IPI.IPITrib == null)
            {
                produtoN.imposto.IPI = new IPI(); // Cria uma nova instância de IPI
                produtoN.imposto.IPI.IPITrib = new IPITrib(); // Cria uma nova instância de IPITrib
                produtoN.imposto.IPI.IPITrib.vIPI = 0; // define valor zerado
            }
            if (produto.imposto.ICMSUFDest == null)
            {
                produtoN.imposto.ICMSUFDest = new ICMSUFDest();
                produtoN.imposto.ICMSUFDest.vICMSUFDest = 0;
            }
            if (produto.imposto.PIS == null || produto.imposto.PIS.PISAliq == null)
            {
                produtoN.imposto.PIS = new PIS();
                produtoN.imposto.PIS.PISAliq = new PISAliq();
                produtoN.imposto.PIS.PISAliq.vPIS = 0;
            }
            if (produto.imposto.COFINS == null || produto.imposto.COFINS.COFINSAliq == null)
            {
                produtoN.imposto.COFINS = new COFINS();
                produtoN.imposto.COFINS.COFINSAliq = new COFINSAliq();
                produtoN.imposto.COFINS.COFINSAliq.vCOFINS = 0;
            }
            if (produto.imposto.ICMSUFDest == null || produto.imposto.ICMSUFDest.vICMSUFDest == null)
            {
                produtoN.imposto.ICMSUFDest = new ICMSUFDest();
                produtoN.imposto.ICMSUFDest.vICMSUFDest = 0;
            }


            return produtoN;
        }
    }






}
