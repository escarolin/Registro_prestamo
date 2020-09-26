using System;
using System.Linq;
using System.Linq.Expressions;
using Registro_prestamo.DAL;
using System.Collections.Generic;
using Registro_prestamo.Entidades;
using Microsoft.EntityFrameworkCore;


namespace Registro_prestamo.BLL{
    public class PrestamoBLL
    {
        public static bool Guardar(Prestamo prestamo)
        {
            if(!Existe(prestamo.PrestamoId))
            return Insertar(prestamo);
            else{
                return Modificar(prestamo);
            }

         
         }
       
       private static bool Insertar (Prestamo prestamo)
       {
           bool paso=false;
           Contexto contexto =new Contexto();
           try{
                //agregar la entidad que decea insertar en el contexto
                 contexto.Prestamo.Add(prestamo);
                 paso=contexto.SaveChanges() >0;

           }
              
             catch (Exception)
             {
                 throw;

             }
             finally
             {
                 contexto.Dispose();
             }
             return paso;
            
       }

       private static bool Modificar (Prestamo prestamo)
       {
           bool paso=false;
           Contexto contexto = new Contexto();
            try 
             {
                 //marcar la intidad como modificada para que el contexto sepa proceder
                 contexto.Prestamo.Add(prestamo);
                 paso=contexto.SaveChanges()>0;

             }
             catch (Exception)
             {
                 throw;
             }
             finally
             {
                 contexto.Dispose();
             }
             return paso;
         }

         public static bool Eliminar (int id)
         {
             bool paso = false;
             Contexto contexto =new Contexto();
             try{
                 //buscar la entida que se desea eliminar
                 var prestamo=contexto.Prestamo.Find(id);
                if (prestamo!=null)
                {
                    contexto.Prestamo.Remove(prestamo); //remover la entidad
                    paso=contexto.SaveChanges()>0;
                }

               }
             catch (Exception)
             {
                 throw;
             }
             finally
             {
                 contexto.Dispose();
             }
             return paso;

         }




             

         public static Prestamo Buscar(int id){
             Contexto contexto= new Contexto();
             Prestamo prestamo;
             try 
             {
                 prestamo=contexto.Prestamo.Find(id);
             }
             catch (Exception)
             {
                 throw;
             }
             finally
             {
                 contexto.Dispose();
             }
             return prestamo;

            }

          public static bool Existe(int id){
              Contexto contexto =new Contexto();
              bool encontrado =false;
              try{
                  encontrado=contexto.Prestamo.Any(e=> e.PrestamoId==id);
              }
              catch(Exception)
   {
       throw;
   }
    finally
    {
        contexto.Dispose();

    }
 return encontrado;

    }
       
      public static List<Prestamo> GetList(Expression<Func<Prestamo,bool>> criterio){
          List<Prestamo>lista=new List<Prestamo>();
          Contexto contexto = new Contexto();
          try
          {
              //Obtener la lista y filtrarla segun el criterio recibido por parametro.
              lista=contexto.Prestamo.Where(criterio).ToList();

          }
          catch(Exception)
   {
       throw;
   }
    finally
    {
        contexto.Dispose();

    }
 return lista;
          
              

          
      }


          }

         }


         

       


