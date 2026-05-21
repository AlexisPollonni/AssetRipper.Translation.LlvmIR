using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class optional_BigInt_128ul_false_unsigned_long_Constructor
{
	[MangledName("_ZN19__llvm_libc_20_1_2_3cpp8optionalINS_6BigIntILm128ELb0EmEEEC2ENS0_9nullopt_tE")]
	[DemangledName("__llvm_libc_20_1_2_::cpp::optional<__llvm_libc_20_1_2_::BigInt<128ul, false, unsigned long>>::optional(__llvm_libc_20_1_2_::cpp::nullopt_t)")]
	public unsafe static void Invoke([NativeType("__llvm_libc_20_1_2_::cpp::nullopt_t")] void* @this)
	{
		OptionalStorage_BigInt_128ul_false_unsigned_long_false_Constructor.Invoke(&unchecked((cpp_optional_neprgb*)@this)->storage);
	}

	[MangledName("_ZN19__llvm_libc_20_1_2_3cpp8optionalINS_6BigIntILm128ELb0EmEEEC2EOS3_")]
	[DemangledName("__llvm_libc_20_1_2_::cpp::optional<__llvm_libc_20_1_2_::BigInt<128ul, false, unsigned long>>::optional(__llvm_libc_20_1_2_::BigInt<128ul, false, unsigned long>&&)")]
	public unsafe static void Invoke(void* @this, [NativeType("__llvm_libc_20_1_2_::BigInt<128ul, false, unsigned long>&&")] anon_izyfb7* t)
	{
		unchecked
		{
			OptionalStorage_BigInt_128ul_false_unsigned_long_false_OptionalStorage_BigInt_128ul_false_unsigned_long.Invoke(&((cpp_optional_neprgb*)@this)->storage, cpp_move_BigInt_128ul_false_unsigned_long.Invoke(t));
			((cpp_optional_neprgb*)@this)->storage.in_use = 1;
		}
	}
}
