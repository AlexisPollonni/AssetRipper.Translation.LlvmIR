using LlvmLibC.Helpers;
using LlvmLibC.Intrinsics.Implemented;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZZN19__llvm_libc_20_1_2_15__acoshf_impl__EfENK3$_0clEf")]
[DemangledName("__llvm_libc_20_1_2_::__acoshf_impl__(float)::$_0::operator()(float) const")]
internal static partial class acoshf_impl_float_0_operator_float_const
{
	public unsafe static float Invoke(void* @this, float r)
	{
		float num = 0f;
		llvm_lifetime_start_p0.Invoke(4L, &num);
		num = r;
		num -= 2.9802322E-08f;
		float result = num;
		llvm_lifetime_end_p0.Invoke(4L, &num);
		return result;
	}
}
