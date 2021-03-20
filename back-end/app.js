const express = require ("express")
const cnpj = require("./routes/cnpj")
const app = express()

app.use ("/cnpj", cnpj)

app.listen(9080, () => {
    console.log("ligado")
})