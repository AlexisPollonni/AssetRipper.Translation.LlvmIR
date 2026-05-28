using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Enumerations;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Callonce_impl_callonce_slowpath
{
	[MangledName("_ZN19__llvm_libc_20_1_2_13callonce_impl17callonce_slowpathEPNS_5FutexEPFvvE")]
	[DemangledName("__llvm_libc_20_1_2_::callonce_impl::callonce_slowpath(__llvm_libc_20_1_2_::Futex*, void (*)())")]
	public unsafe static int Invoke([MangledName("flag")][NativeType("__llvm_libc_20_1_2_::Futex*")] void* Flag, [MangledName("func")][NativeType("void (*)()")] void* Func)
	{
		void* ptr = null;
		int num = 0;
		int num2 = 0;
		int num3 = 0;
		Cpp_optional_r9nbkt cpp_optional_r9nbkt = default(Cpp_optional_r9nbkt);
		Llvm_lifetime_start_p0.Invoke(8L, &ptr);
		ptr = Flag;
		Llvm_lifetime_start_p0.Invoke(4L, &num);
		num = 0;
		unchecked
		{
			int result;
			if (Atomic_unsigned_int_compare_exchange_strong.Invoke(ptr, &num, 17, MemoryOrder.SEQ_CST, MemoryScope.DEVICE))
			{
				((delegate*<void>)Func)();
				Llvm_lifetime_start_p0.Invoke(4L, &num2);
				num2 = Atomic_unsigned_int_exchange.Invoke(ptr, 51, MemoryOrder.SEQ_CST, MemoryScope.DEVICE);
				if (num2 == 34)
				{
					Futex_notify_all.Invoke(ptr, Is_shared: false);
				}
				result = 0;
				Llvm_lifetime_end_p0.Invoke(4L, &num2);
			}
			else
			{
				Llvm_lifetime_start_p0.Invoke(4L, &num3);
				num3 = 17;
				if (Atomic_unsigned_int_compare_exchange_strong.Invoke(ptr, &num3, 34, MemoryOrder.SEQ_CST, MemoryScope.DEVICE) || num3 == 34)
				{
					void* intPtr = ptr;
					Optional_internal_AbsTimeout_Constructor.Invoke((Cpp_optional_59q3zq*)(&cpp_optional_r9nbkt));
					Futex_wait.Invoke(intPtr, 34, &cpp_optional_r9nbkt, Is_shared: false);
				}
				result = 0;
				Llvm_lifetime_end_p0.Invoke(4L, &num3);
			}
			Llvm_lifetime_end_p0.Invoke(4L, &num);
			Llvm_lifetime_end_p0.Invoke(8L, &ptr);
			return result;
		}
	}
}
