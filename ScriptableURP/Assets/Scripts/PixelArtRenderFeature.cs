using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.Rendering.Universal;

public class PixelArtRenderFeature : FullScreenPassRendererFeature
{
    [SerializeField] private Material material;

    class CustomRenderPass : ScriptableRenderPass
    {
        private Material material;
        private RTHandle tempTexture, sourceTexture;

        public CustomRenderPass(Material material)
        {
            this.material = material;
        }

        public override void OnCameraSetup(CommandBuffer cmd, ref RenderingData renderingData)
        {
        }

        public override void Execute(ScriptableRenderContext context, ref RenderingData renderingData)
        {
            
        }

        public override void OnCameraCleanup(CommandBuffer cmd)
        {
        }
    }

    CustomRenderPass m_ScriptablePass;

    public override void Create()
    {
    }

    public override void AddRenderPasses(ScriptableRenderer renderer, ref RenderingData renderingData)
    {
    }
}
