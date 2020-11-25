void CustomLightRamp_half(float Intensity, out float Interpolant)
{
    Interpolant = ceil(Intensity * 4 + 0.25)/ 4;
}
