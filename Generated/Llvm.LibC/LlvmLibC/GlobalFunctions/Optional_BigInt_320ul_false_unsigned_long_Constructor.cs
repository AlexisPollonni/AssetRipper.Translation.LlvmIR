using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Optional_BigInt_320ul_false_unsigned_long_Constructor
{
	[MangledName("_ZN19__llvm_libc_20_1_2_3cpp8optionalINS_6BigIntILm320ELb0EmEEEC2ENS0_9nullopt_tE")]
	[DemangledName("__llvm_libc_20_1_2_::cpp::optional<__llvm_libc_20_1_2_::BigInt<320ul, false, unsigned long>>::optional(__llvm_libc_20_1_2_::cpp::nullopt_t)")]
	public unsafe static void Invoke([MangledName("this")][NativeType("__llvm_libc_20_1_2_::cpp::nullopt_t")] void* This)
	{
		OptionalStorage_BigInt_320ul_false_unsigned_long_false_Constructor.Invoke(&unchecked((Cpp_optional_t82b4p*)This)->Storage);
	}

	[MangledName("_ZN19__llvm_libc_20_1_2_3cpp8optionalINS_6BigIntILm320ELb0EmEEEC2EOS3_")]
	[DemangledName("__llvm_libc_20_1_2_::cpp::optional<__llvm_libc_20_1_2_::BigInt<320ul, false, unsigned long>>::optional(__llvm_libc_20_1_2_::BigInt<320ul, false, unsigned long>&&)")]
	public unsafe static void Invoke([MangledName("this")] void* This, [MangledName("t")][NativeType("__llvm_libc_20_1_2_::BigInt<320ul, false, unsigned long>&&")] BigInt_76gxx6* T)
	{
		unchecked
		{
			OptionalStorage_BigInt_320ul_false_unsigned_long_false_OptionalStorage_BigInt_320ul_false_unsigned_long.Invoke(&((Cpp_optional_t82b4p*)This)->Storage, Cpp_move_BigInt_320ul_false_unsigned_long.Invoke(T));
			((Cpp_optional_t82b4p*)This)->Storage.field_1 = 1;
		}
	}
}
