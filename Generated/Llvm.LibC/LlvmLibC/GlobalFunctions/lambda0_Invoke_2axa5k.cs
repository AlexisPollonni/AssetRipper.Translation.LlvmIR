using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class lambda0_Invoke_2axa5k
{
	[MangledName("_ZZN19__llvm_libc_20_1_2_9multiword5shiftILNS0_9DirectionE0ELb0EtLm1EEENS_3cpp5arrayIT1_XT2_EEES6_mENKUlmE0_clEm")]
	[DemangledName("__llvm_libc_20_1_2_::cpp::array<unsigned short, 1ul> __llvm_libc_20_1_2_::multiword::shift<(__llvm_libc_20_1_2_::multiword::Direction)0, false, unsigned short, 1ul>(__llvm_libc_20_1_2_::cpp::array<unsigned short, 1ul>, unsigned long)::'lambda0'(unsigned long)::operator()(unsigned long) const")]
	[CleanName("lambda0_Invoke")]
	[return: NativeType("__llvm_libc_20_1_2_::cpp::array<unsigned short, 1ul>")]
	public unsafe static short Invoke(void* @this, [NativeType("unsigned long")] long index)
	{
		int num = 0;
		llvm_lifetime_start_p0.Invoke(4L, &num);
		unchecked
		{
			num = lambda_Invoke_x5ppib.Invoke(((anon_6je4un*)@this)->field_0, index);
			short result = (short)((num >= 0) ? ((num < 1) ? (*(short*)array_unsigned_short_1ul_Index_yq9pn3.Invoke((cpp_array_knh6hw*)((anon_6je4un*)@this)->field_1, num)) : 0) : 0);
			llvm_lifetime_end_p0.Invoke(4L, &num);
			return result;
		}
	}
}
