using System;
using System.Collections.Generic;
using System.Text;
using ElGalpon.Models;
using ElGalpon.Repository;

namespace ElGalpon.Business
{
    public class RubrosBus
    {
        //declaro el repositorio
        RubrosRepository rubrosRepository = new RubrosRepository();

        //Método que devuelve una lista de rubros de MENU
        public ResultModel<List<RubroModel>> SelectAllRubrosMenu()
        {
            var response = new ResultModel<List<RubroModel>>();
            try
            {
                response.Return = rubrosRepository.SelectAllRubrosMenu();
            }
            catch (Exception ex)
            {
                response.AddErrorMessage(ex.ToString());
            }

            return response;
        }

        //Método que devuelve una lista de rubros de GASTOS
        public ResultModel<List<RubroModel>> SelectAllRubrosGastos()
        {
            var response = new ResultModel<List<RubroModel>>();
            try
            {
                response.Return = rubrosRepository.SelectAllRubrosGastos();
            }
            catch (Exception ex)
            {
                response.AddErrorMessage(ex.ToString());
            }

            return response;
        }
    }
}
