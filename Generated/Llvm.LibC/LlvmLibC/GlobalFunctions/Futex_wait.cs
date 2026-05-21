using AssetRipper.Translation.LlvmIR.Runtime;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Enumerations;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Futex_wait
{
	[MangledName("_ZN19__llvm_libc_20_1_2_5Futex4waitEjNS_3cpp8optionalINS_8internal10AbsTimeoutEEEb")]
	[DemangledName("__llvm_libc_20_1_2_::Futex::wait(unsigned int, __llvm_libc_20_1_2_::cpp::optional<__llvm_libc_20_1_2_::internal::AbsTimeout>, bool)")]
	public unsafe static long Invoke([MangledName("this")] void* This, [MangledName("expected")][NativeType("unsigned int")] int Expected, [MangledName("timeout")][NativeType("__llvm_libc_20_1_2_::cpp::optional<__llvm_libc_20_1_2_::internal::AbsTimeout>")] void* Timeout, [MangledName("is_shared")][NativeType("bool")] bool Is_shared)
	{
		long result = 0L;
		int num = 0;
		long num2 = 0L;
		sbyte b = (Is_shared ? ((sbyte)1) : ((sbyte)0));
		Llvm_lifetime_start_p0.Invoke(4L, &num);
		num = InstructionHelper.Select((b & 1) == 1, 9, 137);
		unchecked
		{
			if (Optional_internal_AbsTimeout_ToBoolean.Invoke((Llvm_libc_20_1_2_cpp_optional_59q3zq*)Timeout) && AbsTimeout_is_realtime.Invoke(Optional_internal_AbsTimeout_PointerDereference.Invoke((Llvm_libc_20_1_2_cpp_optional_59q3zq*)Timeout)))
			{
				num |= 0x100;
			}
			int num3;
			do
			{
				if (Atomic_unsigned_int_load.Invoke(This, MemoryOrder.RELAXED, MemoryScope.DEVICE) != Expected)
				{
					result = 0L;
					break;
				}
				Llvm_lifetime_start_p0.Invoke(8L, &num2);
				num2 = Llvm_libc_20_1_2_syscall_impl_long_Futex_unsigned_int_unsigned_int_timespec_const_std_nullptr_t_unsigned_int.Invoke(202L, This, num, Expected, (!Optional_internal_AbsTimeout_ToBoolean.Invoke((Llvm_libc_20_1_2_cpp_optional_59q3zq*)Timeout)) ? null : AbsTimeout_get_timespec.Invoke(Optional_internal_AbsTimeout_PointerDereference.Invoke((Llvm_libc_20_1_2_cpp_optional_59q3zq*)Timeout)), null, -1);
				if (num2 == -4L)
				{
					num3 = 3;
				}
				else
				{
					result = num2;
					num3 = 1;
				}
				Llvm_lifetime_end_p0.Invoke(8L, &num2);
			}
			while (num3 == 3);
			Llvm_lifetime_end_p0.Invoke(4L, &num);
			return result;
		}
	}
}
