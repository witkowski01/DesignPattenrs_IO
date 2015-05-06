using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattenrs_IO
{

    abstract class Builder
    {
        protected Product mProduct;

//        public Product Product
//        {
//            get { return mProduct; }
//        }

        public abstract void SetProductCode();
        public abstract void SetProductModel();

        public void CreateProduct()
        {
            mProduct = new Product();
        }

        public Product GeProduct()
        {
            return mProduct;
        }
    }



    class BuilderA : Builder
    {
        public override void SetProductCode()
        {
            mProduct.ProcuctCode = 1;
        }

        public override void SetProductModel()
        {
            mProduct.ProductName = "Blat";
        }
    }

    class BuilderB : Builder
    {

        public override void SetProductCode()
        {
            mProduct.ProcuctCode = 2;
        }

        public override void SetProductModel()
        {
            mProduct.ProductName = "Noga";
        }
    }

    class Director
    {
        private Builder mBuilder;

        public Director(Builder builder)
        {
            mBuilder = builder;
        }

        public void CreateStol()
        {
            mBuilder.CreateProduct();
            mBuilder.SetProductCode();
            mBuilder.SetProductModel();
        }

        public Product GetProduct()
        {
            return mBuilder.GeProduct();
        }
    }

    class Product
    {
        public int ProcuctCode;
        public string ProductName;
    }

    public class Client
    {
        public void CreateProduct()
        {
            BuilderA builderA = new BuilderA();
            BuilderB builderB = new BuilderB();

            Director director = new Director(builderA);
            director.CreateStol();
            Product productA = director.GetProduct();

            director = new Director(builderB);
            director.CreateStol();
            Product productB = director.GetProduct();
        }
    }
}
