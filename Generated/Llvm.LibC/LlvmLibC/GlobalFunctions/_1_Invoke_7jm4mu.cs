using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;

namespace LlvmLibC.GlobalFunctions;

internal static partial class _1_Invoke_7jm4mu
{
	[MangledName("_ZZN19__llvm_libc_20_1_2_15__acoshf_impl__EfENK3$_1clEf")]
	[DemangledName("__llvm_libc_20_1_2_::__acoshf_impl__(float)::$_1::operator()(float) const")]
	[CleanName("_1_Invoke")]
	public unsafe static float Invoke([MangledName("this")] void* This, [MangledName("r")][NativeType("float")] float R)
	{
		float num = 0f;
		Llvm_lifetime_start_p0.Invoke(4L, &num);
		num = R;
		num += 2.9802322E-08f;
		float result = num;
		Llvm_lifetime_end_p0.Invoke(4L, &num);
		return result;
	}
}
