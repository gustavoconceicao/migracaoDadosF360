const mongoose = require("mongoose")
require ("../models/dataCnpj")
const Data = mongoose.model("data")
const bd = require('../utils/banco/conexaoBd')

class cnpjController{
    all(req, res){
        Data.find({}).then( (data) => {
            res.json(data)
        }).catch((err) => {
            console.log(err)
        })
    }
    searchByCnpj(req, res){
        Data.find({
            cnpj: req.params.cnpj
        }).then( (data) => {
            if (data != ""){
              res.json(data)    
            }else{
                res.send("Não foi encontrado nada")
            }            
        }).catch((err) => {
            console.log(err)
        })
        

    }
}

module.exports = new cnpjController()