using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Lambda0_Invoke_92gyaa
{
	[MangledName("_ZZN19__llvm_libc_20_1_2_9multiword5shiftILNS0_9DirectionE0ELb0EmLm258EEENS_3cpp5arrayIT1_XT2_EEES6_mENKUlmE0_clEm")]
	[DemangledName("__llvm_libc_20_1_2_::cpp::array<unsigned long, 258ul> __llvm_libc_20_1_2_::multiword::shift<(__llvm_libc_20_1_2_::multiword::Direction)0, false, unsigned long, 258ul>(__llvm_libc_20_1_2_::cpp::array<unsigned long, 258ul>, unsigned long)::'lambda0'(unsigned long)::operator()(unsigned long) const")]
	[CleanName("Lambda0_Invoke")]
	[return: NativeType("__llvm_libc_20_1_2_::cpp::array<unsigned long, 258ul>")]
	public unsafe static long Invoke([MangledName("this")] void* This, [MangledName("index")][NativeType("unsigned long")] long Index)
	{
		int num = 0;
		Llvm_lifetime_start_p0.Invoke(4L, &num);
		unchecked
		{
			num = Lambda_Invoke_4wih76.Invoke(((Anon_6je4un*)This)->field_0, Index);
			long result = ((num >= 0) ? ((num < 258) ? (*(long*)Array_unsigned_long_258ul_Index_cpunpn.Invoke((Llvm_libc_20_1_2_cpp_array_anzbtp*)((Anon_6je4un*)This)->field_1, num)) : 0) : 0);
			Llvm_lifetime_end_p0.Invoke(4L, &num);
			return result;
		}
	}
}
