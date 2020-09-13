using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Text;
using ElGalpon.Models;
using ElGalpon.Repository;

namespace ElGalpon.Business
{
    public class PersonaBus
    {
        PersonaRepository personaRepository = new PersonaRepository();
        public ResultModel<List<PersonaModel>> SelectAllMozos()
        {
            var response = new ResultModel<List<PersonaModel>>();
            try
            {
                response.Return = personaRepository.SelectAllMozos();
            }
            catch (Exception ex)
            {
                response.AddErrorMessage(ex.ToString());
            }

            return response;
        }
    }
}
