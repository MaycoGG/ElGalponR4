using System;
using System.Collections.Generic;
using System.Text;
using ElGalpon.Models;
using ElGalpon.Repository;

namespace ElGalpon.Business
{
    public class ReservasBus
    {
        ReservasRepository reservasRepository = new ReservasRepository();

        public ResultModel<List<ReservaModel>> SelectAllReservas()
        {
            var response = new ResultModel<List<ReservaModel>>();
            try
            {
                response.Return = reservasRepository.SelectAllReservas();
            }
            catch (Exception ex)
            {
                response.AddErrorMessage(ex.ToString());
            }

            return response;
        }
    }
}
