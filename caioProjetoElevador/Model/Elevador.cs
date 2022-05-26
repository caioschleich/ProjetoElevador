using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace caioProjetoElevador
{
    
    // criação da classe Elevador
    public class Elevador
    {
        
        // criação dos atributos da classe
        
        // total de andares do condomínio
        public int andaresTotal = 10;
        // andar atual conforme comando do usuário. inicial é 0 (térreo)
        public int andarAtual = 0;
        // capacidade total de pessoas do elevador
        public int capacTotal = 6;
        // ocupação inicial padrão do elevador = 0
        public int ocupStd = 0;
        // ocupação do elevador informada ou calculada
        public int ocupNova = 0;
        // número de pessoas que irão sair do elevador
        public int varS = 0;
        // número de pessoas que irão entrar do elevador
        public int varE = 0;
        // nome do condomínio
        public string nomeCondo = "Condomínio";
        // operação do programa
        public string op;
    }

}
