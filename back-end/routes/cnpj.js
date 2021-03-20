var express = require('express');
var cnpjController = require("../controller/cnpjController")
var router = express.Router();

router.get('/all', cnpjController.all);
router.get('/:cnpj', cnpjController.searchByCnpj);

module.exports = router