﻿using NewBanco.Funcionarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewBanco
{
    public class GerenciadorBonificacao
    {
        public double _totalBonificacao;
        public void Registrar (Autenticavel funcionario)
        {
            _totalBonificacao += funcionario.GetBonificacao();
        }
        public double GetTotalBonificacao()
        {
            return _totalBonificacao;
        }
    }
}
