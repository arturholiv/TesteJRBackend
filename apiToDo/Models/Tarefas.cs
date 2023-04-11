﻿using apiToDo.DTO;
using System;
using System.Collections.Generic;
using System.Linq;

namespace apiToDo.Models
{
    public class Tarefas
    {
        public List<TarefaDTO> lstTarefas()
        {
            try
            {
                List<TarefaDTO> lstTarefas = new List<TarefaDTO>();

                lstTarefas.Add(new TarefaDTO
                {
                    ID_TAREFA = 1,
                    DS_TAREFA = "Fazer Compras"
                });

                lstTarefas.Add(new TarefaDTO
                {
                    ID_TAREFA = 2,
                    DS_TAREFA = "Fazer Atividad Faculdade"
                });

                lstTarefas.Add(new TarefaDTO
                {
                    ID_TAREFA = 3,
                    DS_TAREFA = "Subir Projeto de Teste no GitHub"
                });

                return new List<TarefaDTO>();
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }


        public void InserirTarefa(TarefaDTO Request)
        {
            try
            {
                List<TarefaDTO> lstResponse = lstTarefas();
                lstResponse.Add(Request);
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        public void DeletarTarefa(int ID_TAREFA)
        {
            try
            {
                List<TarefaDTO> lstResponse = lstTarefas();
                var tarefa = lstResponse.FirstOrDefault(x => x.ID_TAREFA == ID_TAREFA);
                if (tarefa != null) // Se a Tarefa com o ID recebido no parametro exista (for diferente de nula)
                {
                    lstResponse.Remove(tarefa); // remove a tarefa da lista
                }
                else // Caso a Tarefa não exista na lista
                {
                    throw new Exception($"Tarefa {ID_TAREFA} não encontrada"); // retorna uma exception com tarefa não encontrada
                }
            }
            catch(Exception ex)
            {
                throw new Exception("Ocorreu um erro ao tentar excluir a tarefa", ex);
            }
        }
    }
}
