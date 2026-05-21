using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class lambda0_Invoke_v2e4in
{
	[MangledName("_ZZN19__llvm_libc_20_1_2_9multiword5shiftILNS0_9DirectionE1ELb0EmLm1EEENS_3cpp5arrayIT1_XT2_EEES6_mENKUlmE0_clEm")]
	[DemangledName("__llvm_libc_20_1_2_::cpp::array<unsigned long, 1ul> __llvm_libc_20_1_2_::multiword::shift<(__llvm_libc_20_1_2_::multiword::Direction)1, false, unsigned long, 1ul>(__llvm_libc_20_1_2_::cpp::array<unsigned long, 1ul>, unsigned long)::'lambda0'(unsigned long)::operator()(unsigned long) const")]
	[CleanName("lambda0_Invoke")]
	[return: NativeType("__llvm_libc_20_1_2_::cpp::array<unsigned long, 1ul>")]
	public unsafe static long Invoke(void* @this, [NativeType("unsigned long")] long index)
	{
		int num = 0;
		llvm_lifetime_start_p0.Invoke(4L, &num);
		unchecked
		{
			num = lambda_Invoke_9hkdan.Invoke(((anon_6je4un*)@this)->field_0, index);
			long result = ((num >= 0) ? ((num < 1) ? (*(long*)array_unsigned_long_1ul_Index_3erz3i.Invoke((cpp_array_rpgxvv*)((anon_6je4un*)@this)->field_1, num)) : 0) : 0);
			llvm_lifetime_end_p0.Invoke(4L, &num);
			return result;
		}
	}
}
