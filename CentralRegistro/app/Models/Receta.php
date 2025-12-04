<?php

namespace App\Models;

use Illuminate\Database\Eloquent\Factories\HasFactory;
use Illuminate\Database\Eloquent\Model;

class Receta extends Model
{
    /** @use HasFactory<\Database\Factories\RecetaFactory> */
    use HasFactory;
    protected $fillable = [
        "nombre_paciente",
        "apellido_paciente",
        "fecha",
        "diagnostico",
        "medicamentos",
        "estado"
    ];
}
