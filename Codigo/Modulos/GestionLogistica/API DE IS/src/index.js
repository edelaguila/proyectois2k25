const express = require('express');
const mysql = require('mysql2');
const cors = require('cors');
require('dotenv').config();

const app = express();

// Middleware
app.use(cors());
app.use(express.json());

// Configuración de la conexión a MySQL
const connection = mysql.createConnection({
    host: process.env.DB_HOST || '127.0.0.1',
    port: process.env.DB_PORT || 3306,
    user: process.env.DB_USER || 'soporte',
    password: process.env.DB_PASSWORD || '123456',
    database: process.env.DB_NAME || 'colchoneria'
});

// Conectar a MySQL
connection.connect((err) => {
    if (err) {
        console.error('Error conectando a MySQL:', err);
        return;
    }
    console.log('Conectado a MySQL');
});

// Rutas básicas
app.get('/', (req, res) => {
    res.json({ message: 'Bienvenido a la API' });
});

app.get('/vendedores', (req, res) => {
    connection.query('SELECT * FROM tbl_vendedores', (err, results) => {
        if (err) {
            res.status(500).json({ error: err.message });
            return;
        }
        res.json(results);
    });
});

app.get('/comisiones', (req, res) => {
    connection.query('SELECT * FROM tbl_comisiones_encabezado', (err, results) => {
        if (err) {
            res.status(500).json({ error: err.message });
            return;
        }
        res.json(results);
    });
});

// Puerto
const PORT = process.env.PORT || 3000;
app.listen(PORT, () => {
    console.log(`Servidor corriendo en el puerto ${PORT}`);
}); 