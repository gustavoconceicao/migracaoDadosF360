const mongoose = require("mongoose")
const Schema = mongoose.Schema

const Data = new Schema({
    cnpj:{
        type: String,
        required: true
    },
    identificadoMatrizFilial:{
        type: String,
        required: true
    },
    razaoSocial:{
        type: String,
        required: true
    },
    nomeFantasia:{
        type: String,
        required: true
    },
    capitalSocial:{
        type: String,
        required: true
    },
    situacaoCadastral:{
        type: String,
        required: true
    },
    dataSitualCadastral:{
        type: String,
        required: true
    },
    cep:{
        type: String,
        required: true
    },
    socio: {
        identificadoSocio: {
            type: String
        },
        nomeSocio: {
          type: String
        },
        cnpjSocio: {
          type: String
        }
      }
})

mongoose.model ("data", Data, "data")