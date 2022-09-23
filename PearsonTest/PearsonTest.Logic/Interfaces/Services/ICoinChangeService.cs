using PearsonTest.DTOs;
using System.Collections.Generic;

namespace PearsonTest.Logic.Interfaces.Services
{
    public interface ICoinChangeService
    {
        int HowManyCoinsAreNeeded(double changeRemaining);
    }
}
