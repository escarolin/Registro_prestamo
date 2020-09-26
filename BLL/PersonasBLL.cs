using System;
using System.Linq;
using System.Linq.Expressions;
using Registro_prestamo.DAL;
using System.Collections.Generic;
using Registro_prestamo.Entidades;
using Microsoft.EntityFrameworkCore;


namespace Registro_prestamo.BLL{
    public class PersonasBLL{
           public static bool Guardar (Personas persona)
       {
           if(!Existe(persona.PersonaId))
           return Insetar(persona);
           else{
           return Modificar(persona);
           } 
        
       }
    private static bool Insetar(Personas persona)
         {
             bool paso=false;
             Contexto contexto=new Contexto();
             try
             {
                 //agregar la entidad que decea insertar en el contexto
                 contexto.Personas.Add(persona);
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
          private static bool Modificar(Personas persona)
         {
             bool paso = false; 
             Contexto contexto = new Contexto();
             try 
             {
                 //marcar la intidad como modificada para que el contexto sepa proceder
                 contexto.Personas.Add(persona);
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
      
      public static bool Eliminar(int id)
         {
        bool paso= false;
        Contexto contexto = new Contexto();
        try{
             //buscar la entidad que se desea eliminar
             var persona=contexto.Personas.Find(id);
             if(persona!=null)
             {
                 contexto.Personas.Remove(persona); //remover la entidad
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

      public static Personas Buscar(int id)
         {
           Contexto contexto= new Contexto();
           Personas persona;
           try
           {
               persona=contexto.Personas.Find(id);

           }
           catch (Exception)
             {
                 throw;
             }
             finally
             {
                 contexto.Dispose();
             }
             return persona;

         }

       public static bool Existe (int id ){
   Contexto contexto =new Contexto();
   bool encontrado= false;
   try {
       encontrado=contexto.Personas.Any(e=> e.PersonaId==id);
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
        public static List<Personas> GetList(Expression<Func<Personas, bool>> criterio)
        {
            List<Personas> lista = new List<Personas>();
            Contexto contexto = new Contexto();
            try
            {
                //Obtener la lista y filtrarla segun el criterio recibido por parametro.
                lista = contexto.Personas.Where(criterio).ToList();

            }
            catch (Exception)
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