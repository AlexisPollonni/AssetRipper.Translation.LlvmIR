using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class optional_BigInt_16512ul_false_unsigned_long_Constructor
{
	[MangledName("_ZN19__llvm_libc_20_1_2_3cpp8optionalINS_6BigIntILm16512ELb0EmEEEC2ENS0_9nullopt_tE")]
	[DemangledName("__llvm_libc_20_1_2_::cpp::optional<__llvm_libc_20_1_2_::BigInt<16512ul, false, unsigned long>>::optional(__llvm_libc_20_1_2_::cpp::nullopt_t)")]
	public unsafe static void Invoke([NativeType("__llvm_libc_20_1_2_::cpp::nullopt_t")] cpp_optional_he65ea* @this)
	{
		OptionalStorage_BigInt_16512ul_false_unsigned_long_false_Constructor.Invoke(&@this->storage);
	}

	[MangledName("_ZN19__llvm_libc_20_1_2_3cpp8optionalINS_6BigIntILm16512ELb0EmEEEC2EOS3_")]
	[DemangledName("__llvm_libc_20_1_2_::cpp::optional<__llvm_libc_20_1_2_::BigInt<16512ul, false, unsigned long>>::optional(__llvm_libc_20_1_2_::BigInt<16512ul, false, unsigned long>&&)")]
	public unsafe static void Invoke(cpp_optional_he65ea* @this, [NativeType("__llvm_libc_20_1_2_::BigInt<16512ul, false, unsigned long>&&")] BigInt_q8g275* t)
	{
		OptionalStorage_BigInt_16512ul_false_unsigned_long_false_OptionalStorage_BigInt_16512ul_false_unsigned_long.Invoke(&@this->storage, cpp_move_BigInt_16512ul_false_unsigned_long.Invoke(t));
		@this->storage.in_use = 1;
	}
}
