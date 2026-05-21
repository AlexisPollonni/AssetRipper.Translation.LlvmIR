using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Optional_BigInt_16512ul_false_unsigned_long_Constructor
{
	[MangledName("_ZN19__llvm_libc_20_1_2_3cpp8optionalINS_6BigIntILm16512ELb0EmEEEC2ENS0_9nullopt_tE")]
	[DemangledName("__llvm_libc_20_1_2_::cpp::optional<__llvm_libc_20_1_2_::BigInt<16512ul, false, unsigned long>>::optional(__llvm_libc_20_1_2_::cpp::nullopt_t)")]
	public unsafe static void Invoke([MangledName("this")][NativeType("__llvm_libc_20_1_2_::cpp::nullopt_t")] Llvm_libc_20_1_2_cpp_optional_he65ea* This)
	{
		OptionalStorage_BigInt_16512ul_false_unsigned_long_false_Constructor.Invoke(&This->Storage);
	}

	[MangledName("_ZN19__llvm_libc_20_1_2_3cpp8optionalINS_6BigIntILm16512ELb0EmEEEC2EOS3_")]
	[DemangledName("__llvm_libc_20_1_2_::cpp::optional<__llvm_libc_20_1_2_::BigInt<16512ul, false, unsigned long>>::optional(__llvm_libc_20_1_2_::BigInt<16512ul, false, unsigned long>&&)")]
	public unsafe static void Invoke([MangledName("this")] Llvm_libc_20_1_2_cpp_optional_he65ea* This, [MangledName("t")][NativeType("__llvm_libc_20_1_2_::BigInt<16512ul, false, unsigned long>&&")] Llvm_libc_20_1_2_BigInt_q8g275* T)
	{
		OptionalStorage_BigInt_16512ul_false_unsigned_long_false_OptionalStorage_BigInt_16512ul_false_unsigned_long.Invoke(&This->Storage, Cpp_move_BigInt_16512ul_false_unsigned_long.Invoke(T));
		This->Storage.In_use = 1;
	}
}
