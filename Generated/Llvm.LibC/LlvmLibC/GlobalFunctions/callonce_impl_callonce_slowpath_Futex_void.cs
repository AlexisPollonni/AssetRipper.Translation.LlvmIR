using LlvmLibC.Helpers;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_13callonce_impl17callonce_slowpathEPNS_5FutexEPFvvE")]
[DemangledName("__llvm_libc_20_1_2_::callonce_impl::callonce_slowpath(__llvm_libc_20_1_2_::Futex*, void (*)())")]
internal static partial class callonce_impl_callonce_slowpath_Futex_void
{
	public unsafe static int Invoke(void* flag, void* func)
	{
		void* ptr = null;
		int num = 0;
		int num2 = 0;
		int num3 = 0;
		cpp_optional_7xva92 cpp_optional_7xva93 = default(cpp_optional_7xva92);
		llvm_lifetime_start_p0.Invoke(8L, &ptr);
		ptr = flag;
		llvm_lifetime_start_p0.Invoke(4L, &num);
		num = 0;
		int result;
		if (cpp_Atomic_unsigned_int_compare_exchange_strong_unsigned_int_unsigned_int_cpp_MemoryOrder_cpp_MemoryScope.Invoke(ptr, &num, 17, 5, 1))
		{
			unchecked((delegate*<void>)func)();
			llvm_lifetime_start_p0.Invoke(4L, &num2);
			num2 = cpp_Atomic_unsigned_int_exchange_unsigned_int_cpp_MemoryOrder_cpp_MemoryScope.Invoke(ptr, 51, 5, 1);
			if (num2 == 34)
			{
				Futex_notify_all_bool.Invoke(ptr, is_shared: false);
			}
			result = 0;
			llvm_lifetime_end_p0.Invoke(4L, &num2);
		}
		else
		{
			llvm_lifetime_start_p0.Invoke(4L, &num3);
			num3 = 17;
			if (cpp_Atomic_unsigned_int_compare_exchange_strong_unsigned_int_unsigned_int_cpp_MemoryOrder_cpp_MemoryScope.Invoke(ptr, &num3, 34, 5, 1) || num3 == 34)
			{
				void* intPtr = ptr;
				cpp_optional_internal_AbsTimeout_optional_cpp_nullopt_t.Invoke(&cpp_optional_7xva93);
				Futex_wait_unsigned_int_cpp_optional_internal_AbsTimeout_bool.Invoke(intPtr, 34, &cpp_optional_7xva93, is_shared: false);
			}
			result = 0;
			llvm_lifetime_end_p0.Invoke(4L, &num3);
		}
		llvm_lifetime_end_p0.Invoke(4L, &num);
		llvm_lifetime_end_p0.Invoke(8L, &ptr);
		return result;
	}
}
