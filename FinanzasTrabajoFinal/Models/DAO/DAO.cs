using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FinanzasTrabajoFinal.Models.DAO
{
    public class DAO
    {

        public const double tol = 0.001;
        public delegate double fx(double x);

        public void addCarro(carro obj)
        {
            using (bdFinanzasEntities8 con = new bdFinanzasEntities8())
            {
                con.carroes.Add(obj);
                con.SaveChanges();
            }
        }
        public void addBanco(Banco obj)
        {
            using (bdFinanzasEntities8 con = new bdFinanzasEntities8())
            {
                con.Bancoes.Add(obj);
                con.SaveChanges();
            }
        }

        public void EliminarCarro(int id)
        {
            using (bdFinanzasEntities8 con = new bdFinanzasEntities8())
            {
                carro nuevo = new carro();
                nuevo.idCarro = id;
                con.Entry(nuevo).State = System.Data.Entity.EntityState.Deleted;
                con.SaveChanges();
            }
        }

        public void EliminarBanco(int id)
        {
            using (bdFinanzasEntities8 con = new bdFinanzasEntities8())
            {
                Banco nuevo = new Banco();
                nuevo.idBanco = id;
                con.Entry(nuevo).State = System.Data.Entity.EntityState.Deleted;
                con.SaveChanges();
            }
        }

        public void editarCarro(carro nuevo)
        {
            using (bdFinanzasEntities8 con = new bdFinanzasEntities8())
            {
                con.Entry(nuevo).State = System.Data.Entity.EntityState.Modified;
                con.SaveChanges();
            }
        }

        public List<Marca> MarcaCarros()
        {
            using (bdFinanzasEntities8 con = new bdFinanzasEntities8()) return con.Marcas.ToList();
        }

        public void AddUser(Usuario ent)
        {
            using (bdFinanzasEntities8 con = new bdFinanzasEntities8())
            {
                con.Usuarios.Add(ent);
                con.SaveChanges();
            }
        }

        public void AddBanco(Banco ent)
        {
            using (bdFinanzasEntities8 con = new bdFinanzasEntities8())
            {
                con.Bancoes.Add(ent);
                con.SaveChanges();
            }
        }

        public void AddMarca(Marca ent)
        {
            using (bdFinanzasEntities8 con = new bdFinanzasEntities8())
            {
                con.Marcas.Add(ent);
                con.SaveChanges();
            }
        }

        public void AddCarro(carro ent)
        {
            using (bdFinanzasEntities8 con = new bdFinanzasEntities8())
            {
                con.carroes.Add(ent);
                con.SaveChanges();
            }
        }

        public void editarBanco(Banco nuevo)
        {
            using (bdFinanzasEntities8 con = new bdFinanzasEntities8())
            {
                con.Entry(nuevo).State = System.Data.Entity.EntityState.Modified;
                con.SaveChanges();
            }
        }
        public Usuario Log(string email,string pass)
        {
            using (bdFinanzasEntities8 con = new bdFinanzasEntities8())
            {
                var data = (from u in con.Usuarios where u.Email == email && u.password == pass select u).ToList();
                Usuario logeado = null;

                foreach (var item in data)
                {
                    logeado = new Usuario();
                    logeado.idDNI = item.idDNI;
                    logeado.NNombre = item.NNombre;
                    logeado.Email = item.Email;
                    logeado.password = item.password;
                    logeado.NApellido = item.NApellido;
                    logeado.Ntipo = item.Ntipo;
                }
                return logeado;
            }
        }
        public Banco datosBancoXID(int id)
        {
            using (bdFinanzasEntities8 con = new bdFinanzasEntities8())
            {
                var data = (from u in con.Bancoes where u.idBanco == id select u).ToList();
                Banco banco = null;

                foreach (var item in data)
                {
                    banco = new Banco();
                    banco.idBanco = item.idBanco;
                    banco.NombreBanco = item.NombreBanco;
                    banco.TEA = item.TEA;
                    banco.comActivacion = item.comActivacion;
                    banco.comEstudio = item.comEstudio;
                    banco.costesNotariales = item.costesNotariales;
                    banco.comPeriodica = item.comPeriodica;
                    banco.costesRegistrales = item.costesRegistrales;
                    banco.ks = item.ks;
                    banco.PorRecompa = item.PorRecompa;
                    banco.PorsegRiesgo = item.PorsegRiesgo;
                    banco.SeguroRiesgo = item.SeguroRiesgo;
                    banco.Tasacion = item.Tasacion;
                    banco.wacc = item.wacc;

                }
                return banco;
            }
        }
        //entidad Frecuencia
        public Frecuencia frecuenciaDD(String id)
        {
            using (bdFinanzasEntities8 con = new bdFinanzasEntities8())
            {
                var Did = Int32.Parse(id);
                var data = (from u in con.Frecuencias where u.idFrecuencia == Did select u).ToList();
                Frecuencia fr = null;

                foreach (var item in data)
                {
                    fr = new Frecuencia();
                    fr.idFrecuencia = item.idFrecuencia;
                    fr.NNombre = item.NNombre;
                    fr.cantidadDias = item.cantidadDias;

                }
                return fr;
            }
        }

        
        public List<Banco> listBanco()
        {
            using (bdFinanzasEntities8 con = new bdFinanzasEntities8()) return con.Bancoes.ToList();

        }
        //listaCarros
        public List<carro> listCarros()
        {
            using (bdFinanzasEntities8 con = new bdFinanzasEntities8()) return con.carroes.ToList();
            
        }

        public void Registro(Usuario obj)
        {
            using (bdFinanzasEntities8 con = new bdFinanzasEntities8())
            {
                con.Usuarios.Add(obj);
                con.SaveChanges();
            }
        }

        public Banco entBanco(int id)
        {
            using (bdFinanzasEntities8 con = new bdFinanzasEntities8())
            {

                var data = (from u in con.Bancoes where u.idBanco == id select u).ToList();
                Banco cr = null;

                foreach (var item in data)
                {
                    cr = new Banco();
                    cr.idBanco = item.idBanco;
                    cr.idUsuario = item.idUsuario;
                    cr.NombreBanco = item.NombreBanco;
                    cr.TEA = item.TEA;
                    cr.SeguroRiesgo = item.SeguroRiesgo;
                    cr.PorRecompa = item.PorRecompa;
                    cr.costesNotariales = item.costesNotariales;
                    cr.costesRegistrales = item.costesRegistrales;
                    cr.Tasacion = item.Tasacion;
                    cr.comEstudio = item.comEstudio;
                    cr.comActivacion = item.comActivacion;
                    cr.comPeriodica = item.comPeriodica;
                    cr.PorsegRiesgo = item.PorsegRiesgo;
                    cr.ks = item.ks;
                    cr.wacc = item.wacc;
                    
                }
                return cr;
            }
        }

        public carro entCarro(int id)
        {
            using (bdFinanzasEntities8 con = new bdFinanzasEntities8())
            {
                
                var data = (from u in con.carroes where u.idCarro == id select u).ToList();
                carro cr = null;

                foreach (var item in data)
                {
                    cr = new carro();
                    cr.idCarro = item.idCarro;
                    cr.NCarro = item.NCarro;
                    cr.idMarca = item.idMarca;
                    cr.Precio = item.Precio;

                }
                return cr;
            }
        }

        //entidad Carro
        public carro carroEntid(String id)
        {
            using (bdFinanzasEntities8 con = new bdFinanzasEntities8())
            {
                var Did = Int32.Parse(id);
                var data = (from u in con.carroes where u.idCarro == Did select u).ToList();
                carro cr = null;

                foreach (var item in data)
                {
                    cr = new carro();
                    cr.idCarro  = item.idCarro;
                    cr.NCarro = item.NCarro;
                    cr.idMarca = item.idMarca;
                    cr.Precio = item.Precio;

                }
                return cr;
            }
        }


        /*TIR*/
        /*
        public double TceaFlujB()
        {
            double[] payments = { -35528.31, 30, 30, 30, 4286.13, 4286.13, 4286.13, 4286.13, 4286.13, 4286.13, 4286.13, 4286.13, 4625.11 }; // payments
            double[] days = { 0, 30, 60, 90, 120, 150, 180, 210, 240, 270, 300, 330, 360 }; // days of payment (as day of year)
            double tir = Newtons_method(0.01,
                                         total_f_xirr(payments, days),
                                         total_df_xirr(payments, days));
            var tcea = Math.Pow(1 + tir, 360 / 12);
            var tceaFB = tcea - 1;
            return tceaFB;

        }
        public double TceaFlujN()
        {
            double[] payments = { -35528.31, 30, 30, 30, 4286.13, 4286.13, 4286.13, 4286.13, 4286.13, 4286.13, 4286.13, 4286.13, 4625.11 }; // payments
            double[] days = { 0, 30, 60, 90, 120, 150, 180, 210, 240, 270, 300, 330, 360 }; // days of payment (as day of year)
            double tir = Newtons_method(0.01,
                                         total_f_xirr(payments, days),
                                         total_df_xirr(payments, days));
            var tcea = Math.Pow(1 + tir, 360 / 12);
            var tceaFB = tcea - 1;
            return tcea;

        }
        public double VanFlujoN()
        {
            double[] payments = { -35528.31, 30, 30, 30, 4286.13, 4286.13, 4286.13, 4286.13, 4286.13, 4286.13, 4286.13, 4286.13, 4625.11 }; // payments
            double[] days = { 0, 30, 60, 90, 120, 150, 180, 210, 240, 270, 300, 330, 360 }; // days of payment (as day of year)
            double tcea = Newtons_method(0.01,
                                         total_f_xirr(payments, days),
                                         total_df_xirr(payments, days));
            return tcea;

        }
        public double VanFlujoB()
        {
            double[] payments = { -35528.31, 30, 30, 30, 4286.13, 4286.13, 4286.13, 4286.13, 4286.13, 4286.13, 4286.13, 4286.13, 4625.11 }; // payments
            double[] days = { 0, 30, 60, 90, 120, 150, 180, 210, 240, 270, 300, 330, 360 }; // days of payment (as day of year)
            double tcea = Newtons_method(0.01,
                                         total_f_xirr(payments, days),
                                         total_df_xirr(payments, days));
            return tcea;

        }

        public double tir()
        {
            double[] payments = { -35528.31, 30, 30, 30, 4286.13, 4286.13, 4286.13, 4286.13, 4286.13, 4286.13, 4286.13, 4286.13,4625.11 }; // payments
            double[] days = { 0, 30, 60, 90, 120, 150, 180, 210, 240, 270, 300, 330, 360 }; // days of payment (as day of year)
            double xirr = Newtons_method(0.00000001,
                                         total_f_xirr(payments, days),
                                         total_df_xirr(payments, days));

            
            return xirr;
        }
        */


        double LOW_RATE = -4.01;
        double HIGH_RATE = 0.5;
        double MAX_ITERATION = 1000;
        double PRECISION_REQ = 0.00000001;

        protected Double computeIRR(double[] cf, int numOfFlows)
        {
            int i = 0, j = 0;
            double  m = 0.0;
            double old = 0.00;
            double aux = 0.00;
            double oldguessRate = LOW_RATE;
            double auxguessRate = LOW_RATE;
            double guessRate = LOW_RATE;
            double lowGuessRate = LOW_RATE;
            double highGuessRate = HIGH_RATE;
            double npv = 0.0;
            double denom = 0.0;
            for (i = 0; i < MAX_ITERATION; i++)
            {
                npv = 0.00;
                for (j = 0; j < numOfFlows; j++)
                {
                    denom = Math.Pow((1 + guessRate), j);
                    npv = npv + (cf[j] / denom);
                }
                /* Stop checking once the required precision is achieved */
                if ((npv > 0) && (npv < PRECISION_REQ))
                    break;
                if (old == 0)
                    old = npv;
                else
                    old = aux;
                aux = npv;
                if (i > 0)
                {
                    if (old < aux)
                    {
                        if (old < 0 && aux < 0)
                            highGuessRate = auxguessRate;
                        else
                            lowGuessRate = auxguessRate;
                    }
                    else
                    {
                        if (old > 0 && aux > 0)
                            lowGuessRate = auxguessRate;
                        else
                            highGuessRate = auxguessRate;
                    }
                }
                oldguessRate = guessRate;
                guessRate = (lowGuessRate + highGuessRate) / 2;
                auxguessRate = guessRate;
            }
            return guessRate;
        }


        public double tir(double[] ff,int cantCuot)
        {
            double[] cf = new double[30];
            double irr = 0.00;
            int numOfFlows;
            cf[0] = -35528.31;
            cf[1] = 30;
            cf[2] = 30;
            cf[3] = 30;
            cf[4] = 4286.13;
            cf[5] = 4286.13;
            cf[6] = 4286.13;
            cf[7] = 4286.13;
            cf[8] = 4286.13;
            cf[9] = 4286.13;
            cf[10] = 4286.13;
            cf[11] = 4286.13;
            cf[12] = 4625.11;
            numOfFlows = 13;
            irr = computeIRR(ff, cantCuot+1);
            return irr;
        }

    }
}