const mongoose = require("mongoose")

const db =  mongoose.connect("mongodb://root:example@192.168.0.32:27017/dadosEmpresas?authSource=admin", {useUnifiedTopology: true, useNewUrlParser: true }).catch(error => console.log(error)).then(console.log("sucesso"))

module.exports = db;
