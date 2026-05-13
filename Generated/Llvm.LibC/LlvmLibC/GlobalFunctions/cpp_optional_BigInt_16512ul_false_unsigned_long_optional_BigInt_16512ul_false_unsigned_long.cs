using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_3cpp8optionalINS_6BigIntILm16512ELb0EmEEEC2EOS3_")]
[DemangledName("__llvm_libc_20_1_2_::cpp::optional<__llvm_libc_20_1_2_::BigInt<16512ul, false, unsigned long>>::optional(__llvm_libc_20_1_2_::BigInt<16512ul, false, unsigned long>&&)")]
internal static partial class cpp_optional_BigInt_16512ul_false_unsigned_long_optional_BigInt_16512ul_false_unsigned_long
{
	public unsafe static void Invoke(cpp_optional_tchbah* @this, BigInt_k36xhe* t)
	{
		cpp_optional_BigInt_16512ul_false_unsigned_long_OptionalStorage_BigInt_16512ul_false_unsigned_long_false_OptionalStorage_BigInt_16512ul_false_unsigned_long_cpp_in_place_t_BigInt_16512ul_false_unsigned_long.Invoke(&@this->storage, cpp_remove_reference_BigInt_16512ul_false_unsigned_long_type_cpp_move_BigInt_16512ul_false_unsigned_long_BigInt_16512ul_false_unsigned_long.Invoke(t));
		@this->storage.in_use = 1;
	}
}
