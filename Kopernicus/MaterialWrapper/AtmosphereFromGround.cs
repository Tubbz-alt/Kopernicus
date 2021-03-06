// Material wrapper generated by shader translator tool
using System;
using System.Reflection;
using UnityEngine;

namespace Kopernicus
{
    namespace MaterialWrapper
    {
        public class AtmosphereFromGround : Material
        {
            // Internal property ID tracking object
            protected class Properties
            {
                // Return the shader for this wrapper
                private const string shaderName = "AtmosphereFromGround";
                public static Shader shader
                {
                    get { return Shader.Find (shaderName); }
                }

                // Offset Transform, default = (0,0,0,1)
                private const string offsetTransformKey = "_OffsetTransform";
                public int offsetTransformID { get; private set; }

                // Camera Position, default = (0,0,0,0)
                private const string v4CameraPosKey = "_v4CameraPos";
                public int v4CameraPosID { get; private set; }

                // Light Direction, default = (0,0,0,0)
                private const string v4LightDirKey = "_v4LightDir";
                public int v4LightDirID { get; private set; }

                // Inverse WaveLength, default = (0,0,0,0)
                private const string cInvWaveLengthKey = "_cInvWaveLength";
                public int cInvWaveLengthID { get; private set; }

                // Camera Height, default = 0
                private const string fCameraHeightKey = "_fCameraHeight";
                public int fCameraHeightID { get; private set; }

                // Camera Height2, default = 0
                private const string fCameraHeight2Key = "_fCameraHeight2";
                public int fCameraHeight2ID { get; private set; }

                // Outer Radius, default = 0
                private const string fOuterRadiusKey = "_fOuterRadius";
                public int fOuterRadiusID { get; private set; }

                // Outer Radius 2, default = 0
                private const string fOuterRadius2Key = "_fOuterRadius2";
                public int fOuterRadius2ID { get; private set; }

                // Inner Radius, default = 0
                private const string fInnerRadiusKey = "_fInnerRadius";
                public int fInnerRadiusID { get; private set; }

                // Inner Radius 2, default = 0
                private const string fInnerRadius2Key = "_fInnerRadius2";
                public int fInnerRadius2ID { get; private set; }

                // KrESun, default = 0
                private const string fKrESunKey = "_fKrESun";
                public int fKrESunID { get; private set; }

                // KmESun, default = 0
                private const string fKmESunKey = "_fKmESun";
                public int fKmESunID { get; private set; }

                // Kr4PI, default = 0
                private const string fKr4PIKey = "_fKr4PI";
                public int fKr4PIID { get; private set; }

                // Km4PI, default = 0
                private const string fKm4PIKey = "_fKm4PI";
                public int fKm4PIID { get; private set; }

                // Scale, default = 0
                private const string fScaleKey = "_fScale";
                public int fScaleID { get; private set; }

                // Scale Depth, default = 0
                private const string fScaleDepthKey = "_fScaleDepth";
                public int fScaleDepthID { get; private set; }

                // Scale Over Scale Depth, default = 0
                private const string fScaleOverScaleDepthKey = "_fScaleOverScaleDepth";
                public int fScaleOverScaleDepthID { get; private set; }

                // Samples, default = 0
                private const string samplesKey = "_Samples";
                public int samplesID { get; private set; }

                // G, default = 0
                private const string gKey = "_G";
                public int gID { get; private set; }

                // G2, default = 0
                private const string g2Key = "_G2";
                public int g2ID { get; private set; }

                // Singleton instance
                private static Properties singleton = null;
                public static Properties Instance
                {
                    get
                    {
                        // Construct the singleton if it does not exist
                        if(singleton == null)
                            singleton = new Properties();
            
                        return singleton;
                    }
                }

                private Properties()
                {
                    offsetTransformID = Shader.PropertyToID(offsetTransformKey);
                    v4CameraPosID = Shader.PropertyToID(v4CameraPosKey);
                    v4LightDirID = Shader.PropertyToID(v4LightDirKey);
                    cInvWaveLengthID = Shader.PropertyToID(cInvWaveLengthKey);
                    fCameraHeightID = Shader.PropertyToID(fCameraHeightKey);
                    fCameraHeight2ID = Shader.PropertyToID(fCameraHeight2Key);
                    fOuterRadiusID = Shader.PropertyToID(fOuterRadiusKey);
                    fOuterRadius2ID = Shader.PropertyToID(fOuterRadius2Key);
                    fInnerRadiusID = Shader.PropertyToID(fInnerRadiusKey);
                    fInnerRadius2ID = Shader.PropertyToID(fInnerRadius2Key);
                    fKrESunID = Shader.PropertyToID(fKrESunKey);
                    fKmESunID = Shader.PropertyToID(fKmESunKey);
                    fKr4PIID = Shader.PropertyToID(fKr4PIKey);
                    fKm4PIID = Shader.PropertyToID(fKm4PIKey);
                    fScaleID = Shader.PropertyToID(fScaleKey);
                    fScaleDepthID = Shader.PropertyToID(fScaleDepthKey);
                    fScaleOverScaleDepthID = Shader.PropertyToID(fScaleOverScaleDepthKey);
                    samplesID = Shader.PropertyToID(samplesKey);
                    gID = Shader.PropertyToID(gKey);
                    g2ID = Shader.PropertyToID(g2Key);
                }
            }

            // Offset Transform, default = (0,0,0,1)
            public Vector4 offsetTransform
            {
                get { return GetVector (Properties.Instance.offsetTransformID); }
                set { SetVector (Properties.Instance.offsetTransformID, value); }
            }

            // Camera Position, default = (0,0,0,0)
            public Vector4 v4CameraPos
            {
                get { return GetVector (Properties.Instance.v4CameraPosID); }
                set { SetVector (Properties.Instance.v4CameraPosID, value); }
            }

            // Light Direction, default = (0,0,0,0)
            public Vector4 v4LightDir
            {
                get { return GetVector (Properties.Instance.v4LightDirID); }
                set { SetVector (Properties.Instance.v4LightDirID, value); }
            }

            // Inverse WaveLength, default = (0,0,0,0)
            public Color cInvWaveLength
            {
                get { return GetColor (Properties.Instance.cInvWaveLengthID); }
                set { SetColor (Properties.Instance.cInvWaveLengthID, value); }
            }

            // Camera Height, default = 0
            public float fCameraHeight
            {
                get { return GetFloat (Properties.Instance.fCameraHeightID); }
                set { SetFloat (Properties.Instance.fCameraHeightID, value); }
            }

            // Camera Height2, default = 0
            public float fCameraHeight2
            {
                get { return GetFloat (Properties.Instance.fCameraHeight2ID); }
                set { SetFloat (Properties.Instance.fCameraHeight2ID, value); }
            }

            // Outer Radius, default = 0
            public float fOuterRadius
            {
                get { return GetFloat (Properties.Instance.fOuterRadiusID); }
                set { SetFloat (Properties.Instance.fOuterRadiusID, value); }
            }

            // Outer Radius 2, default = 0
            public float fOuterRadius2
            {
                get { return GetFloat (Properties.Instance.fOuterRadius2ID); }
                set { SetFloat (Properties.Instance.fOuterRadius2ID, value); }
            }

            // Inner Radius, default = 0
            public float fInnerRadius
            {
                get { return GetFloat (Properties.Instance.fInnerRadiusID); }
                set { SetFloat (Properties.Instance.fInnerRadiusID, value); }
            }

            // Inner Radius 2, default = 0
            public float fInnerRadius2
            {
                get { return GetFloat (Properties.Instance.fInnerRadius2ID); }
                set { SetFloat (Properties.Instance.fInnerRadius2ID, value); }
            }

            // KrESun, default = 0
            public float fKrESun
            {
                get { return GetFloat (Properties.Instance.fKrESunID); }
                set { SetFloat (Properties.Instance.fKrESunID, value); }
            }

            // KmESun, default = 0
            public float fKmESun
            {
                get { return GetFloat (Properties.Instance.fKmESunID); }
                set { SetFloat (Properties.Instance.fKmESunID, value); }
            }

            // Kr4PI, default = 0
            public float fKr4PI
            {
                get { return GetFloat (Properties.Instance.fKr4PIID); }
                set { SetFloat (Properties.Instance.fKr4PIID, value); }
            }

            // Km4PI, default = 0
            public float fKm4PI
            {
                get { return GetFloat (Properties.Instance.fKm4PIID); }
                set { SetFloat (Properties.Instance.fKm4PIID, value); }
            }

            // Scale, default = 0
            public float fScale
            {
                get { return GetFloat (Properties.Instance.fScaleID); }
                set { SetFloat (Properties.Instance.fScaleID, value); }
            }

            // Scale Depth, default = 0
            public float fScaleDepth
            {
                get { return GetFloat (Properties.Instance.fScaleDepthID); }
                set { SetFloat (Properties.Instance.fScaleDepthID, value); }
            }

            // Scale Over Scale Depth, default = 0
            public float fScaleOverScaleDepth
            {
                get { return GetFloat (Properties.Instance.fScaleOverScaleDepthID); }
                set { SetFloat (Properties.Instance.fScaleOverScaleDepthID, value); }
            }

            // Samples, default = 0
            public float samples
            {
                get { return GetFloat (Properties.Instance.samplesID); }
                set { SetFloat (Properties.Instance.samplesID, value); }
            }

            // G, default = 0
            public float g
            {
                get { return GetFloat (Properties.Instance.gID); }
                set { SetFloat (Properties.Instance.gID, value); }
            }

            // G2, default = 0
            public float g2
            {
                get { return GetFloat (Properties.Instance.g2ID); }
                set { SetFloat (Properties.Instance.g2ID, value); }
            }

            public AtmosphereFromGround() : base(Properties.shader)
            {
            }

            public AtmosphereFromGround(string contents) : base(contents)
            {
                base.shader = Properties.shader;
            }

            public AtmosphereFromGround(Material material) : base(material)
            {
                // Throw exception if this material was not the proper material
                if (material.shader.name != Properties.shader.name)
                    throw new InvalidOperationException("Type Mismatch: AtmosphereFromGround shader required");
            }

        }
    }
}
