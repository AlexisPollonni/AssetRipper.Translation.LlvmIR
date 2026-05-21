using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class lambda0_Invoke_djj25e
{
	[MangledName("_ZZN19__llvm_libc_20_1_2_9multiword5shiftILNS0_9DirectionE0ELb0EmLm4EEENS_3cpp5arrayIT1_XT2_EEES6_mENKUlmE0_clEm")]
	[DemangledName("__llvm_libc_20_1_2_::cpp::array<unsigned long, 4ul> __llvm_libc_20_1_2_::multiword::shift<(__llvm_libc_20_1_2_::multiword::Direction)0, false, unsigned long, 4ul>(__llvm_libc_20_1_2_::cpp::array<unsigned long, 4ul>, unsigned long)::'lambda0'(unsigned long)::operator()(unsigned long) const")]
	[CleanName("lambda0_Invoke")]
	[return: NativeType("__llvm_libc_20_1_2_::cpp::array<unsigned long, 4ul>")]
	public unsafe static long Invoke(void* @this, [NativeType("unsigned long")] long index)
	{
		int num = 0;
		llvm_lifetime_start_p0.Invoke(4L, &num);
		unchecked
		{
			num = lambda_Invoke_sdb5rs.Invoke(((anon_6je4un*)@this)->field_0, index);
			long result = ((num >= 0) ? ((num < 4) ? (*(long*)array_unsigned_long_4ul_Index_6jyt8f.Invoke((cpp_array_jgy3xh*)((anon_6je4un*)@this)->field_1, num)) : 0) : 0);
			llvm_lifetime_end_p0.Invoke(4L, &num);
			return result;
		}
	}
}
