using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MODEL;
using DAL;

namespace BLL
{
    public class BLLProduto
    {
        //Inclusao
        public IEnumerable<produto> Inclusao(produto oProduto)
        {
            if (Consulta(oProduto.Sku) == null)
            {
                Dal_Repositorio.Produto.Add(oProduto);
            }
            else 
            {
                throw new System.InvalidOperationException("Código SKU existente");
            }

            return Consulta(oProduto.Sku);
        }

        //Consulta
        public IEnumerable<produto> Consulta(long nCodigoSKU = 0)
        {
            if (nCodigoSKU != 0)
            {
                if (Dal_Repositorio.Produto.Exists(a => a.Sku == nCodigoSKU))
                {
                    return Dal_Repositorio.Produto.Where(a => a.Sku == nCodigoSKU);
                }
                else
                {
                    return null;
                }
            }
            else
            {
                return Dal_Repositorio.Produto;
            }
        }

        //Exclusao
        public bool Remover(long nCodigoSKU)
        {
            bool bRetorno = false;

            if (Dal_Repositorio.Produto.Exists(a => a.Sku == nCodigoSKU))
            {
                Dal_Repositorio.Produto.RemoveAll(a => a.Sku == nCodigoSKU);
                bRetorno = true;
            }

            return bRetorno;
        }

    }
}
