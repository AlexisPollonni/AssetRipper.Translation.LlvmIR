using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Optional_BigInt_16512ul_false_unsigned_long_value
{
	[MangledName("_ZNR19__llvm_libc_20_1_2_3cpp8optionalINS_6BigIntILm16512ELb0EmEEE5valueEv")]
	[DemangledName("__llvm_libc_20_1_2_::cpp::optional<__llvm_libc_20_1_2_::BigInt<16512ul, false, unsigned long>>::value() &")]
	public unsafe static BigInt_q8g275* Invoke([MangledName("this")] Cpp_optional_he65ea* This)
	{
		return unchecked((BigInt_q8g275*)(&This->Storage.field));
	}
}
