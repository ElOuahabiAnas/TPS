namespace TP4
{
    public class Absence
    {
        public int NumSemaine { get; set; }
        public int EleveID { get; set; }
        public int NbrAbsences { get; set; }

        public Absence(int numSemaine, int eleveID, int nbrAbsences)
        {
            NumSemaine = numSemaine;
            EleveID = eleveID;
            NbrAbsences = nbrAbsences;
        }
    }

    
}