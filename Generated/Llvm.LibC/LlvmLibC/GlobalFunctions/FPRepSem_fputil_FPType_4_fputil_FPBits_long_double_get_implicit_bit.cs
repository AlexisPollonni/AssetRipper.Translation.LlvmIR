using AssetRipper.Translation.LlvmIR.Runtime;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class FPRepSem_fputil_FPType_4_fputil_FPBits_long_double_get_implicit_bit
{
	[MangledName("_ZNK19__llvm_libc_20_1_2_6fputil8internal8FPRepSemILNS0_6FPTypeE4ENS0_6FPBitsIeEEE16get_implicit_bitEv")]
	[DemangledName("__llvm_libc_20_1_2_::fputil::internal::FPRepSem<(__llvm_libc_20_1_2_::fputil::FPType)4, __llvm_libc_20_1_2_::fputil::FPBits<long double>>::get_implicit_bit() const")]
	public unsafe static bool Invoke([MangledName("this")] void* This)
	{
		return NumericHelper.IntCmpNe(NumericHelper.BitwiseAnd(unchecked((Fputil_internal_FPStorage_w3h7gw*)This)->field_0, long.MinValue), 0L);
	}
}
