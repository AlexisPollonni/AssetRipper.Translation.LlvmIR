using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Lambda0_Invoke_3hws57
{
	[MangledName("_ZZN19__llvm_libc_20_1_2_9multiword5shiftILNS0_9DirectionE1ELb0EmLm5EEENS_3cpp5arrayIT1_XT2_EEES6_mENKUlmE0_clEm")]
	[DemangledName("__llvm_libc_20_1_2_::cpp::array<unsigned long, 5ul> __llvm_libc_20_1_2_::multiword::shift<(__llvm_libc_20_1_2_::multiword::Direction)1, false, unsigned long, 5ul>(__llvm_libc_20_1_2_::cpp::array<unsigned long, 5ul>, unsigned long)::'lambda0'(unsigned long)::operator()(unsigned long) const")]
	[CleanName("Lambda0_Invoke")]
	[return: NativeType("__llvm_libc_20_1_2_::cpp::array<unsigned long, 5ul>")]
	public unsafe static long Invoke([MangledName("this")] void* This, [MangledName("index")][NativeType("unsigned long")] long Index)
	{
		int num = 0;
		Llvm_lifetime_start_p0.Invoke(4L, &num);
		unchecked
		{
			num = Lambda_Invoke_yubd88.Invoke(((Anon_6je4un*)This)->field_0, Index);
			long result = ((num >= 0) ? ((num < 5) ? (*(long*)Array_unsigned_long_5ul_Index_wu6ki8.Invoke((Llvm_libc_20_1_2_cpp_array_msasyg*)((Anon_6je4un*)This)->field_1, num)) : 0) : 0);
			Llvm_lifetime_end_p0.Invoke(4L, &num);
			return result;
		}
	}
}
