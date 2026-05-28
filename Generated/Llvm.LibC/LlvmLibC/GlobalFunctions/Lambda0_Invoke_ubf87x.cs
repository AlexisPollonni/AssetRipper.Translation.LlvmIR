using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Lambda0_Invoke_ubf87x
{
	[MangledName("_ZZN19__llvm_libc_20_1_2_9multiword5shiftILNS0_9DirectionE0ELb0EmLm1EEENS_3cpp5arrayIT1_XT2_EEES6_mENKUlmE0_clEm")]
	[DemangledName("__llvm_libc_20_1_2_::cpp::array<unsigned long, 1ul> __llvm_libc_20_1_2_::multiword::shift<(__llvm_libc_20_1_2_::multiword::Direction)0, false, unsigned long, 1ul>(__llvm_libc_20_1_2_::cpp::array<unsigned long, 1ul>, unsigned long)::'lambda0'(unsigned long)::operator()(unsigned long) const")]
	[CleanName("Lambda0_Invoke")]
	[return: NativeType("__llvm_libc_20_1_2_::cpp::array<unsigned long, 1ul>")]
	public unsafe static long Invoke([MangledName("this")] void* This, [MangledName("index")][NativeType("unsigned long")] long Index)
	{
		int num = 0;
		Llvm_lifetime_start_p0.Invoke(4L, &num);
		unchecked
		{
			num = Lambda_Invoke_uakzmb.Invoke(((Anon_6je4un*)This)->field_0, Index);
			long result = ((num >= 0) ? ((num < 1) ? (*(long*)Array_unsigned_long_1ul_Index_3erz3i.Invoke((Cpp_array_rpgxvv*)((Anon_6je4un*)This)->field_1, num)) : 0) : 0);
			Llvm_lifetime_end_p0.Invoke(4L, &num);
			return result;
		}
	}
}
