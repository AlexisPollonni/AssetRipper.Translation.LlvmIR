using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZZN19__llvm_libc_20_1_2_15__asinhf_impl__EfENK3$_0clEf")]
[DemangledName("__llvm_libc_20_1_2_::__asinhf_impl__(float)::$_0::operator()(float) const")]
internal static partial class asinhf_impl_float_0_operator_float_const
{
	public unsafe static float Invoke(void* @this, float r)
	{
		return unchecked(fputil_multiply_add_float_float_float.Invoke((float)((anon_6i3r2b*)@this)->field_0, r, (float)((anon_6i3r2b*)@this)->field_0 * -5.9604645E-08f));
	}
}
