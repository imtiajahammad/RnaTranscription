using System;
namespace RnaTranscription
{
	public static class RnaTranscription
	{
        public static string ToRna(string nucleotide)
        {
            var dnaToRna = new DnaToRnaTranscription();
            return dnaToRna.Transcript(nucleotide);
            /*if(nucleotide.Equals("C")) return "G";
            if(nucleotide.Equals("G")) return "C";
            if(nucleotide.Equals("T")) return "A";
            if(nucleotide.Equals("A")) return "U";
            if(nucleotide.Equals("ACGTGGTCTTAA")) return "UGCACCAGAAUU";
            return "";*/
        }
    }
}

