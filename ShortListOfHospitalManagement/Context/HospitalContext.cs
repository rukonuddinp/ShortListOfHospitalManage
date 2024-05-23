using Microsoft.EntityFrameworkCore;
using ShortListOfHospitalManagement.Models;

namespace ShortListOfHospitalManagement.Context
{
    public class HospitalContext:DbContext
    {
        public HospitalContext(DbContextOptions<HospitalContext> options): base(options)
        {
            
        }

        public DbSet<Patient> Patients { get; set; }
        public DbSet<DiseaseInformation> DiseaseInformations { get; set; }
        public DbSet<NCD> NCDs { get; set; }
        public DbSet<Allergy> Allergies { get; set; }
        public DbSet<NCD_Detail> NCD_Details { get; set; }
        public DbSet<Allergies_Detail> Allergies_Details { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<NCD_Detail>()
                .HasOne(n => n.Patient)
                .WithMany(p => p.NCD_Details)
                .HasForeignKey(n => n.PatientID);

            modelBuilder.Entity<NCD_Detail>()
                .HasOne(n => n.NCD)
                .WithMany()
                .HasForeignKey(n => n.NCDID);

            modelBuilder.Entity<Allergies_Detail>()
                .HasOne(a => a.Patient)
                .WithMany(p => p.Allergies_Details)
                .HasForeignKey(a => a.PatientID);

            modelBuilder.Entity<Allergies_Detail>()
                .HasOne(a => a.Allergy)
                .WithMany()
                .HasForeignKey(a => a.AllergyID);
            modelBuilder.Entity<DiseaseInformation>().HasData(
                new DiseaseInformation { ID=1, DiseaseName= "Fever" },
                new DiseaseInformation { ID=2, DiseaseName= "Chickenpox" },
                new DiseaseInformation { ID=3, DiseaseName= "COVID-19" },
                new DiseaseInformation { ID=4, DiseaseName= "Measles" },
                new DiseaseInformation { ID=5, DiseaseName= "Meningitis" },
                new DiseaseInformation { ID=6, DiseaseName= "Monkeypox" }
                );

            modelBuilder.Entity<NCD>().HasData(
                new NCD { ID = 1, NCDName = "Asthma" },
                new NCD { ID = 2, NCDName = "Cancer" },
                new NCD { ID = 3, NCDName = "Disorder of ear" },
                new NCD { ID = 4, NCDName = "Disorder of eye" },
                new NCD { ID = 5, NCDName = "Mental Illness" },
                new NCD { ID = 6, NCDName = "Oral Health Problem" },
                new NCD { ID = 7, NCDName = "Hypertension" }
            );

            modelBuilder.Entity<Allergy>().HasData(
                new Allergy { ID = 1, AllergyName = "Drugs-Penicillin" },
                new Allergy { ID = 2, AllergyName = "Drugs-Others" },
                new Allergy { ID = 3, AllergyName = "Animals" },
                new Allergy { ID = 4, AllergyName = "Food" },
                new Allergy { ID = 5, AllergyName = "Oinments" },
                new Allergy { ID = 6, AllergyName = "Plants" },
                new Allergy { ID = 7, AllergyName = "Sprays" },
                new Allergy { ID = 8, AllergyName = "Other" }
            );
        }

    }
}
