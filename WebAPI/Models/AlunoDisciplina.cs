﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace WEBAPI
{
    public class AlunoDisciplina
    {

        public AlunoDisciplina(){}

        public AlunoDisciplina(int AlunoId, int DisciplinaId){
            this.AlunoId = AlunoId;
            this.DisciplinaId = DisciplinaId;
        }
        public int AlunoId { get; set; }
        public Aluno Aluno { get; set; }

        public int DisciplinaId { get; set; }
        public Disciplina Disciplina { get; set; }
    }
}
