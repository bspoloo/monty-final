<?php

namespace App\Http\Controllers;

use App\Models\Receta;
use Illuminate\Http\Request;

class RecetaController extends Controller
{
    /**
     * Display a listing of the resource.
     */
    public function index()
    {
        return response()->json(Receta::all());
    }

    /**
     * Store a newly created resource in storage.
     */
    public function store(Request $request)
    {
        $receta = Receta::create($request->all());
        return response()->json($receta, 201);
    }

    /**
     * Display the specified resource.
     */
    public function show(Receta $receta)
    {
        return response()->json($receta);
    }

    /**
     * Update the specified resource in storage.
     */
    public function update(Request $request, Receta $receta)
    {
        $receta->update($request->all());
        return response()->json($receta);
    }

    /**
     * Remove the specified resource from storage.
     */
    public function destroy(Receta $receta)
    {
        $receta->delete();
        return response()->json($receta, 204);
    }
}
