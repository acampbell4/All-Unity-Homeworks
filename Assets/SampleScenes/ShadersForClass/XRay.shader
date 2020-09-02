Shader "ZackAlmighty/XRay"
{
   
    SubShader
    {
       Tags { "Queue"="Transparent +1" }    //render after all Transparent OBJECTS (queue=3000)
       Pass  {  Blend Zero One}             //makes objects transparent
    }
}
