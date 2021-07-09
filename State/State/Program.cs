using System;

namespace State
{
    class Program
    {
        static void Main(string[] args)
        {
            DihydrogenOxide testSubject = new DihydrogenOxide();
            testSubject.CoolDown();
            testSubject.CoolDown();
            testSubject.HeatUp();
            testSubject.HeatUp();
            testSubject.HeatUp();
            testSubject.CoolDown();
        }
    }
}
