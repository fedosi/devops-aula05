using System;
using Xunit;
using conversaotemperatura.Controllers;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

 

namespace conversaotemperaturateste
{
    public class TesteConversaoTemperatura
    {

 

        private conversaotemperatura.Controllers.conversao service;
        private const double dblFatorKelvin = 273.15;

 

        public TesteConversaoTemperatura()
        {
            service = new conversaotemperatura.Controllers.conversao();

 

        }
        [Fact]
        public void Get_WhenCalled_ReturnsZeroCelsiusToZeroKelvin()
        {
            // Act
            var okResult = service.Get("CK","0");
            
            // Assert
            Assert.True(Math.Abs(Convert.ToDouble(okResult.ValorDestino)).Equals(dblFatorKelvin));
            
        }

 

        [Fact]
        public void Get_WhenCalled_ReturnsZeroCelsiusToZeroKelvinFailure()
        {
            // Act
            var okResult = service.Get("KC", "-273,15");
          
            // Assert
           Assert.False(Convert.ToDouble(okResult.ValorDestino).Equals(dblFatorKelvin));
        }

 


        [Theory]
        [InlineData("CK","100,67")]
        [InlineData("KC","373,15")]
        [InlineData("CK", "-1,46")]
        [InlineData("KC", "-243,15")]
        [InlineData("CK", "10,")]
        [InlineData("KC", "43")]
        [InlineData("CK", "-22")]
        [InlineData("KC", "-77")]
        [InlineData("CK", "0,")]
        [InlineData("KC", "0")]

 

        public void Get_WhenCalled_ReturnsConversaoSucesso(string _tipoconversao, string _valororigem)
        {
            // Act
            var okResult = service.Get(_tipoconversao, _valororigem);
 
            // Assert
           double resultado = Math.Round(Convert.ToDouble(okResult.ValorDestino),2) - Math.Round(Convert.ToDouble(okResult.ValorOrigem),2);
           Assert.True(Math.Abs(Math.Round(resultado,2)).Equals(Math.Round(dblFatorKelvin,2) ));           
                  
        }
    }

 

}