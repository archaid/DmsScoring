using DmsScoring.Models;

public static class DefaultScoringData
{
    public static List<ScoringRow> GetRows()
    {
        return new List<ScoringRow>
        {
            // === INFORMASI 1 ===
            new ScoringRow { Id=1, Group="INFORMASI 1", BobotB=5, GroupItem="Umur Pemohon", BobotD=30, Item="56 - 65 Tahun", BobotF=25 },
            new ScoringRow { Id=2, Group="INFORMASI 1", BobotB=5, GroupItem="Umur Pemohon", BobotD=30, Item="21 - 30 Tahun", BobotF=50 },
            new ScoringRow { Id=3, Group="INFORMASI 1", BobotB=5, GroupItem="Umur Pemohon", BobotD=30, Item="31 - 45 Tahun", BobotF=100 },
            new ScoringRow { Id=4, Group="INFORMASI 1", BobotB=5, GroupItem="Umur Pemohon", BobotD=30, Item="46 - 55 Tahun", BobotF=75 },
            new ScoringRow { Id=5, Group="INFORMASI 1", BobotB=5, GroupItem="Umur Pemohon + Tenor", BobotD=10, Item="Diatas Ketentuan", BobotF=25 },
            new ScoringRow { Id=6, Group="INFORMASI 1", BobotB=5, GroupItem="Umur Pemohon + Tenor", BobotD=10, Item="Dibawah Ketentuan", BobotF=100 },

            new ScoringRow { Id=7, Group="INFORMASI 1", BobotB=5, GroupItem="Status Perkawinan", BobotD=40, Item="Belum Kawin dengan > 2 tanggungan", BobotF=25 },
            new ScoringRow { Id=8, Group="INFORMASI 1", BobotB=5, GroupItem="Status Perkawinan", BobotD=40, Item="Belum Kawin dengan <= 2 tanggungan", BobotF=45 },
            new ScoringRow { Id=9, Group="INFORMASI 1", BobotB=5, GroupItem="Status Perkawinan", BobotD=40, Item="Belum Kawin dengan 0 tanggungan", BobotF=65 },
            new ScoringRow { Id=10, Group="INFORMASI 1", BobotB=5, GroupItem="Status Perkawinan", BobotD=40, Item="Kawin dengan > 2 tanggungan", BobotF=85 },
            new ScoringRow { Id=11, Group="INFORMASI 1", BobotB=5, GroupItem="Status Perkawinan", BobotD=40, Item="Kawin dengan <= 2 tanggungan", BobotF=100 },

            new ScoringRow { Id=12, Group="INFORMASI 1", BobotB=5, GroupItem="Pendidikan", BobotD=20, Item="SMA atau dibawahnya", BobotF=25 },
            new ScoringRow { Id=13, Group="INFORMASI 1", BobotB=5, GroupItem="Pendidikan", BobotD=20, Item="D1, D2, D3, D4", BobotF=50 },
            new ScoringRow { Id=14, Group="INFORMASI 1", BobotB=5, GroupItem="Pendidikan", BobotD=20, Item="S1", BobotF=75 },
            new ScoringRow { Id=15, Group="INFORMASI 1", BobotB=5, GroupItem="Pendidikan", BobotD=20, Item="Master atau diatasnya (S2,S3)", BobotF=100 },

            // === INFORMASI 2 ===
            new ScoringRow { Id=16, Group="INFORMASI 2", BobotB=5, GroupItem="Alamat tempat tinggal", BobotD=40, Item="Tidak sesuai dengan data Bank", BobotF=25 },
            new ScoringRow { Id=17, Group="INFORMASI 2", BobotB=5, GroupItem="Alamat tempat tinggal", BobotD=40, Item="Sesuai dengan data Bank", BobotF=100 },

            new ScoringRow { Id=18, Group="INFORMASI 2", BobotB=5, GroupItem="Kepemilikan tempat tinggal", BobotD=30, Item="Lain-lain", BobotF=25 },
            new ScoringRow { Id=19, Group="INFORMASI 2", BobotB=5, GroupItem="Kepemilikan tempat tinggal", BobotD=30, Item="Sewa / Kontrak", BobotF=50 },
            new ScoringRow { Id=20, Group="INFORMASI 2", BobotB=5, GroupItem="Kepemilikan tempat tinggal", BobotD=30, Item="Milik sendiri masih diangsur", BobotF=75 },
            new ScoringRow { Id=21, Group="INFORMASI 2", BobotB=5, GroupItem="Kepemilikan tempat tinggal", BobotD=30, Item="Milik sendiri", BobotF=100 },

            new ScoringRow { Id=22, Group="INFORMASI 2", BobotB=5, GroupItem="Lama menempati", BobotD=30, Item="<= 2 tahun", BobotF=25 },
            new ScoringRow { Id=23, Group="INFORMASI 2", BobotB=5, GroupItem="Lama menempati", BobotD=30, Item="> 2 - 5 tahun", BobotF=50 },
            new ScoringRow { Id=24, Group="INFORMASI 2", BobotB=5, GroupItem="Lama menempati", BobotD=30, Item="> 5 - 8 tahun", BobotF=75 },
            new ScoringRow { Id=25, Group="INFORMASI 2", BobotB=5, GroupItem="Lama menempati", BobotD=30, Item="> 8 tahun", BobotF=100 },

            // === INFORMASI 3 ===
            new ScoringRow { Id=26, Group="INFORMASI 3", BobotB=20, GroupItem="Kategori Perusahaan", BobotD=20, Item="Lembaga Departemen", BobotF=100 },
            new ScoringRow { Id=27, Group="INFORMASI 3", BobotB=20, GroupItem="Kategori Perusahaan", BobotD=20, Item="BUMD", BobotF=25 },
            new ScoringRow { Id=28, Group="INFORMASI 3", BobotB=20, GroupItem="Kategori Perusahaan", BobotD=20, Item="SWASTA tidak punya rating", BobotF=100 },
            new ScoringRow { Id=29, Group="INFORMASI 3", BobotB=20, GroupItem="Kategori Perusahaan", BobotD=20, Item="SWASTA dengan rating", BobotF=25 },
            new ScoringRow { Id=30, Group="INFORMASI 3", BobotB=20, GroupItem="Kategori Perusahaan", BobotD=20, Item="SWASTA Kategori I", BobotF=75 },
            new ScoringRow { Id=31, Group="INFORMASI 3", BobotB=20, GroupItem="Kategori Perusahaan", BobotD=20, Item="SWASTA Kategori II", BobotF=50 },
            new ScoringRow { Id=32, Group="INFORMASI 3", BobotB=20, GroupItem="Kategori Perusahaan", BobotD=20, Item="SWASTA Kategori III", BobotF=0 },

            new ScoringRow { Id=33, Group="INFORMASI 3", BobotB=20, GroupItem="Jabatan", BobotD=20, Item="Staff", BobotF=25 },
            new ScoringRow { Id=34, Group="INFORMASI 3", BobotB=20, GroupItem="Jabatan", BobotD=20, Item="Direktur", BobotF=75 },
            new ScoringRow { Id=35, Group="INFORMASI 3", BobotB=20, GroupItem="Jabatan", BobotD=20, Item="Komisaris", BobotF=100 },

            new ScoringRow { Id=36, Group="INFORMASI 3", BobotB=20, GroupItem="Lama bekerja", BobotD=20, Item="<= 2 Tahun", BobotF=0 },
            new ScoringRow { Id=37, Group="INFORMASI 3", BobotB=20, GroupItem="Lama bekerja", BobotD=20, Item="> 2 - 5 Tahun", BobotF=25 },
            new ScoringRow { Id=38, Group="INFORMASI 3", BobotB=20, GroupItem="Lama bekerja", BobotD=20, Item="> 5 - 10 Tahun", BobotF=75 },
            new ScoringRow { Id=39, Group="INFORMASI 3", BobotB=20, GroupItem="Lama bekerja", BobotD=20, Item="> 10 Tahun", BobotF=100 },

            new ScoringRow { Id=40, Group="INFORMASI 3", BobotB=20, GroupItem="Pendapatan THP", BobotD=40, Item="<= Rp 10 juta", BobotF=25 },
            new ScoringRow { Id=41, Group="INFORMASI 3", BobotB=20, GroupItem="Pendapatan THP", BobotD=40, Item="> Rp 10 - Rp 25 juta", BobotF=50 },
            new ScoringRow { Id=42, Group="INFORMASI 3", BobotB=20, GroupItem="Pendapatan THP", BobotD=40, Item="> Rp 25 - Rp 50 juta", BobotF=75 },
            new ScoringRow { Id=43, Group="INFORMASI 3", BobotB=20, GroupItem="Pendapatan THP", BobotD=40, Item="> Rp 50 juta", BobotF=100 },

            // === INFORMASI 4 ===
            new ScoringRow { Id=44, Group="INFORMASI 4", BobotB=15, GroupItem="Rekening Bank", BobotD=10, Item="Tidak ada", BobotF=25 },
            new ScoringRow { Id=45, Group="INFORMASI 4", BobotB=15, GroupItem="Rekening Bank", BobotD=10, Item="Tabungan", BobotF=50 },
            new ScoringRow { Id=46, Group="INFORMASI 4", BobotB=15, GroupItem="Rekening Bank", BobotD=10, Item="Giro", BobotF=75 },
            new ScoringRow { Id=47, Group="INFORMASI 4", BobotB=15, GroupItem="Rekening Bank", BobotD=10, Item="Tabungan/Giro + Deposito", BobotF=100 },

            new ScoringRow { Id=48, Group="INFORMASI 4", BobotB=15, GroupItem="Rata-rata saldo per bulannya", BobotD=15, Item="<= Rp 10 juta", BobotF=25 },
            new ScoringRow { Id=49, Group="INFORMASI 4", BobotB=15, GroupItem="Rata-rata saldo per bulannya", BobotD=15, Item="Rp 10 - Rp 25 juta", BobotF=50 },
            new ScoringRow { Id=50, Group="INFORMASI 4", BobotB=15, GroupItem="Rata-rata saldo per bulannya", BobotD=15, Item="Rp 25 - Rp 50 juta", BobotF=75 },
            new ScoringRow { Id=51, Group="INFORMASI 4", BobotB=15, GroupItem="Rata-rata saldo per bulannya", BobotD=15, Item="> Rp 50 juta", BobotF=100 },

            new ScoringRow { Id=52, Group="INFORMASI 4", BobotB=15, GroupItem="Track record pembayaran angsuran", BobotD=15, Item="Peminjam baru", BobotF=25 },
            new ScoringRow { Id=53, Group="INFORMASI 4", BobotB=15, GroupItem="Track record pembayaran angsuran", BobotD=15, Item="Angsuran terlambat tapi lancar", BobotF=50 },
            new ScoringRow { Id=54, Group="INFORMASI 4", BobotB=15, GroupItem="Track record pembayaran angsuran", BobotD=15, Item="Angsuran tepat waktu", BobotF=100 },

            new ScoringRow { Id=55, Group="INFORMASI 4", BobotB=15, GroupItem="Track Data SLIK", BobotD=40, Item="Kolektibilitas 3 sd 5", BobotF=0 },
            new ScoringRow { Id=56, Group="INFORMASI 4", BobotB=15, GroupItem="Track Data SLIK", BobotD=40, Item="Ada tunggakan < 3 bulan", BobotF=50 },
            new ScoringRow { Id=57, Group="INFORMASI 4", BobotB=15, GroupItem="Track Data SLIK", BobotD=40, Item="Tidak ada fasilitas", BobotF=75 },
            new ScoringRow { Id=58, Group="INFORMASI 4", BobotB=15, GroupItem="Track Data SLIK", BobotD=40, Item="Lancar", BobotF=100 },

            new ScoringRow { Id=59, Group="INFORMASI 4", BobotB=15, GroupItem="Kepemilikan Kartu Kredit", BobotD=20, Item="Tidak Ada", BobotF=25 },
            new ScoringRow { Id=60, Group="INFORMASI 4", BobotB=15, GroupItem="Kepemilikan Kartu Kredit", BobotD=20, Item="Basic", BobotF=50 },
            new ScoringRow { Id=61, Group="INFORMASI 4", BobotB=15, GroupItem="Kepemilikan Kartu Kredit", BobotD=20, Item="Gold", BobotF=75 },
            new ScoringRow { Id=62, Group="INFORMASI 4", BobotB=15, GroupItem="Kepemilikan Kartu Kredit", BobotD=20, Item="Platinum atau diatasnya", BobotF=100 },

            // === INFORMASI 5 ===
            new ScoringRow { Id=63, Group="INFORMASI 5", BobotB=30, GroupItem="Tenor", BobotD=25, Item="> 15 Tahun", BobotF=25 },
            new ScoringRow { Id=64, Group="INFORMASI 5", BobotB=30, GroupItem="Tenor", BobotD=25, Item="> 10 - 15 Tahun", BobotF=50 },
            new ScoringRow { Id=65, Group="INFORMASI 5", BobotB=30, GroupItem="Tenor", BobotD=25, Item="> 5 - 10 Tahun", BobotF=75 },
            new ScoringRow { Id=66, Group="INFORMASI 5", BobotB=30, GroupItem="Tenor", BobotD=25, Item="<= 5 Tahun", BobotF=100 },

            new ScoringRow { Id=67, Group="INFORMASI 5", BobotB=30, GroupItem="Debt Service Ratio", BobotD=75, Item="> 50%", BobotF=0 },
            new ScoringRow { Id=68, Group="INFORMASI 5", BobotB=30, GroupItem="Debt Service Ratio", BobotD=75, Item="> 40 - 50%", BobotF=50 },
            new ScoringRow { Id=69, Group="INFORMASI 5", BobotB=30, GroupItem="Debt Service Ratio", BobotD=75, Item="> 30 - 40%", BobotF=75 },
            new ScoringRow { Id=70, Group="INFORMASI 5", BobotB=30, GroupItem="Debt Service Ratio", BobotD=75, Item="<= 30%", BobotF=100 },

            // === INFORMASI 6 ===
            new ScoringRow { Id=71, Group="INFORMASI 6", BobotB=25, GroupItem="Hasil Appraisal", BobotD=10, Item="Tidak Direkomendasikan", BobotF=0 },
            new ScoringRow { Id=72, Group="INFORMASI 6", BobotB=25, GroupItem="Hasil Appraisal", BobotD=10, Item="Marketable", BobotF=100 },

            new ScoringRow { Id=73, Group="INFORMASI 6", BobotB=25, GroupItem="Luas Bangunan", BobotD=20, Item="> 200 M2", BobotF=25 },
            new ScoringRow { Id=74, Group="INFORMASI 6", BobotB=25, GroupItem="Luas Bangunan", BobotD=20, Item="> 100 - 200 M2", BobotF=50 },
            new ScoringRow { Id=75, Group="INFORMASI 6", BobotB=25, GroupItem="Luas Bangunan", BobotD=20, Item="> 45 - 100 M2", BobotF=75 },
            new ScoringRow { Id=76, Group="INFORMASI 6", BobotB=25, GroupItem="Luas Bangunan", BobotD=20, Item="<= 45 M2", BobotF=100 },

            new ScoringRow { Id=77, Group="INFORMASI 6", BobotB=25, GroupItem="Tujuan dari Pembiayaan", BobotD=10, Item="Lain-Lain", BobotF=25 },
            new ScoringRow { Id=78, Group="INFORMASI 6", BobotB=25, GroupItem="Tujuan dari Pembiayaan", BobotD=10, Item="Disewakan/Investasi", BobotF=50 },
            new ScoringRow { Id=79, Group="INFORMASI 6", BobotB=25, GroupItem="Tujuan dari Pembiayaan", BobotD=10, Item="Renovasi", BobotF=75 },
            new ScoringRow { Id=80, Group="INFORMASI 6", BobotB=25, GroupItem="Tujuan dari Pembiayaan", BobotD=10, Item="Pertama & Ditempati Sendiri", BobotF=100 },

            new ScoringRow { Id=81, Group="INFORMASI 6", BobotB=25, GroupItem="LTV", BobotD=60, Item="LTV > 90%", BobotF=25 },
            new ScoringRow { Id=82, Group="INFORMASI 6", BobotB=25, GroupItem="LTV", BobotD=60, Item="LTV > 80%", BobotF=50 },
            new ScoringRow { Id=83, Group="INFORMASI 6", BobotB=25, GroupItem="LTV", BobotD=60, Item="LTV > 70%", BobotF=75 },
            new ScoringRow { Id=84, Group="INFORMASI 6", BobotB=25, GroupItem="LTV", BobotD=60, Item="LTV <= 70%", BobotF=100 },
            new ScoringRow { Id=85, Group="INFORMASI 6", BobotB=25, GroupItem="LTV", BobotD=60, Item="LTV > 100%", BobotF=0 }
        };
    }
}
