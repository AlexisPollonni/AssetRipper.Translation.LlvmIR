using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Optional_BigInt_320ul_false_unsigned_long_value
{
	[MangledName("_ZNO19__llvm_libc_20_1_2_3cpp8optionalINS_6BigIntILm320ELb0EmEEE5valueEv")]
	[DemangledName("__llvm_libc_20_1_2_::cpp::optional<__llvm_libc_20_1_2_::BigInt<320ul, false, unsigned long>>::value() &&")]
	public unsafe static Llvm_libc_20_1_2_BigInt_76gxx6* Invoke([MangledName("this")] void* This)
	{
		return Cpp_move_BigInt_320ul_false_unsigned_long.Invoke(unchecked((Llvm_libc_20_1_2_BigInt_76gxx6*)(&((Llvm_libc_20_1_2_cpp_optional_t82b4p*)This)->Storage.field)));
	}
}
