'use strict';

var Pelicula = require('../models/Pelicula');
var express = require('express');
var router = express.Router();

/* GET users listing. */
router.get('/', async function (req, res) {
    const peliculas = await Pelicula.findAll();
    res.json(peliculas);
});

router.post('/', async function (req, res) {
    let { Titulo, Genero, Director, Anio } = req.body;
    let pelicula = await Pelicula.create({
        titulo: Titulo,
        genero: Genero,
        director: Director,
        anio: Anio,

    });
    res.json(pelicula);
});

module.exports = router;
