'use strict';

const { Sequelize } = require('sequelize');
const sequelize = new Sequelize({
    dialect: 'sqlite',
    storage: './storage/bdpeli.sqlite'
});

const Pelicula = sequelize.define('Pelicula', {
    id: {
        primaryKey: true,
        type: Sequelize.BIGINT,
        autoIncrement: true
    },
    titulo: {
        type: Sequelize.STRING

    },
    genero: {
        type: Sequelize.STRING
    },
    director: {
        type: Sequelize.STRING
    },
    anio: {
        type: Sequelize.STRING
    },

});

Pelicula.sync();

module.exports = Pelicula;