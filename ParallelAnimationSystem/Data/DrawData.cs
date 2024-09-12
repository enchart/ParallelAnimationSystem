using OpenTK.Mathematics;
using ParallelAnimationSystem.Rendering;

namespace ParallelAnimationSystem.Data;

public record struct DrawData(
    RenderType RenderType,
    MeshHandle Mesh,
    TextHandle Text,
    Matrix3 Transform,
    Color4<Rgba> Color1,
    Color4<Rgba> Color2,
    float Z,
    RenderMode RenderMode);