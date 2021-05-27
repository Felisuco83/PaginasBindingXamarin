using SQLite;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;
using XamarinBBDD.Dependencies;
using XamarinBBDD.Models;
using System.Linq;

namespace XamarinBBDD.Repositories
{
    public class RepositoryDepartamentos
    {
        SQLiteConnection cn;
        public RepositoryDepartamentos()
        {
            this.cn = DependencyService.Get<IDataBase>().GetConnection();
        }

        public void CrearBBDD()
        {
            this.cn.DropTable<Departamento>();
            this.cn.CreateTable<Departamento>();
        }

        public List<Departamento> GetDepartamentos()
        {
            return  (from datos in this.cn.Table<Departamento>() select datos).ToList();
        }

        public Departamento FindDepartamento (int id)
        {
            return (from datos in this.cn.Table<Departamento>() where datos.IdDepartamento == id select datos).FirstOrDefault();
        }

        public void InsertarDepartamento(int id, string nombre, string localidad)
        {
            Departamento dept = new Departamento();
            dept.IdDepartamento = id;
            dept.Nombre = nombre;
            dept.Localidad = localidad;
            this.cn.Insert(dept);
        }

        public void EliminarDepartamento(int id)
        {
            Departamento departamento = this.FindDepartamento(id);
            this.cn.Delete<Departamento>(departamento);
        }

        public void UpdateDepartamento(int id, string nombre, string localidad)
        {
            Departamento departamento = this.FindDepartamento(id);
            departamento.Nombre = nombre;
            departamento.Localidad = localidad;
            this.cn.Update(departamento);
        }
    }
}
