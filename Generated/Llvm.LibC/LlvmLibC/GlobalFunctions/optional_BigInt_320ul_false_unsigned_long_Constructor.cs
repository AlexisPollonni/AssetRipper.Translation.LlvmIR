using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class optional_BigInt_320ul_false_unsigned_long_Constructor
{
	[MangledName("_ZN19__llvm_libc_20_1_2_3cpp8optionalINS_6BigIntILm320ELb0EmEEEC2ENS0_9nullopt_tE")]
	[DemangledName("__llvm_libc_20_1_2_::cpp::optional<__llvm_libc_20_1_2_::BigInt<320ul, false, unsigned long>>::optional(__llvm_libc_20_1_2_::cpp::nullopt_t)")]
	public unsafe static void Invoke([NativeType("__llvm_libc_20_1_2_::cpp::nullopt_t")] void* @this)
	{
		OptionalStorage_BigInt_320ul_false_unsigned_long_false_Constructor.Invoke(&unchecked((cpp_optional_t82b4p*)@this)->storage);
	}

	[MangledName("_ZN19__llvm_libc_20_1_2_3cpp8optionalINS_6BigIntILm320ELb0EmEEEC2EOS3_")]
	[DemangledName("__llvm_libc_20_1_2_::cpp::optional<__llvm_libc_20_1_2_::BigInt<320ul, false, unsigned long>>::optional(__llvm_libc_20_1_2_::BigInt<320ul, false, unsigned long>&&)")]
	public unsafe static void Invoke(void* @this, [NativeType("__llvm_libc_20_1_2_::BigInt<320ul, false, unsigned long>&&")] BigInt_76gxx6* t)
	{
		unchecked
		{
			OptionalStorage_BigInt_320ul_false_unsigned_long_false_OptionalStorage_BigInt_320ul_false_unsigned_long.Invoke(&((cpp_optional_t82b4p*)@this)->storage, cpp_move_BigInt_320ul_false_unsigned_long.Invoke(t));
			((cpp_optional_t82b4p*)@this)->storage.field_1 = 1;
		}
	}
}
