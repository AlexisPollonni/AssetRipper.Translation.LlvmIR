using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class _1_Invoke_9pzp2z
{
	[MangledName("_ZZN19__llvm_libc_20_1_2_15__asinhf_impl__EfENK3$_1clEf")]
	[DemangledName("__llvm_libc_20_1_2_::__asinhf_impl__(float)::$_1::operator()(float) const")]
	[CleanName("_1_Invoke")]
	public unsafe static float Invoke(void* @this, [NativeType("float")] float r)
	{
		return unchecked(fputil_multiply_add_float.Invoke((float)((anon_prxz47*)@this)->field_0, r, (float)((anon_prxz47*)@this)->field_0 * 5.9604645E-08f));
	}
}
