<?php

namespace Database\Factories;

use Illuminate\Database\Eloquent\Factories\Factory;

/**
 * @extends \Illuminate\Database\Eloquent\Factories\Factory<\App\Models\Receta>
 */
class RecetaFactory extends Factory
{
    /**
     * Define the model's default state.
     *
     * @return array<string, mixed>
     */
    public function definition(): array
    {
        return [
            "nombre_paciente" => $this->faker->firstName(),
            "apellido_paciente" => $this->faker->lastName(),
            "fecha" => $this->faker->date(),
            "diagnostico" => $this->faker->sentence(),
            "medicamentos" => $this->faker->sentence(),
            "estado" => $this->faker->randomElement(["emitido", "vendida"]),
        ];
    }
}
