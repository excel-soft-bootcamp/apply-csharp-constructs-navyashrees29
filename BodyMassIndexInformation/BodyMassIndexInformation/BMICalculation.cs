﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BodyMassIndexInformation
{
    class BMICalculation
    {
        private float height;
        private float weight;
        private float bmiValue;

        public BMICalculation(float height, float weight)

        {
            this.height = height;
            this.weight = weight;
        }
       

        public float getHeight()
        {
            return this.height;
        }
        public float getWeight()
        {
            return this.weight;
        }
        public float getbmiValue()
        {
            return this.bmiValue;
        }


        public void  BmiCalculation()
        {
            this.bmiValue= this.weight / this.height;

        }



    }
}
