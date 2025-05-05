const fs = require("fs");

class KuliahMahasiswa2211104080 {
  static ReadJSON() {
    const filePath = "./tp7_2_2211104080.json";
    const jsonData = fs.readFileSync(filePath, "utf-8");
    const data = JSON.parse(jsonData);

    console.log("Daftar mata kuliah yang diambil:");
    data.mata_kuliah.forEach((mk, index) => {
      console.log(`MK ${index + 1} <${mk.kode}> - <${mk.nama}>`);
    });
  }
}

module.exports = KuliahMahasiswa2211104080;